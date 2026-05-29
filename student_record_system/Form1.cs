using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace student_record_system
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost;port=3306;database=student_db;uid=root;pwd=;";
        string selectedStudentId = "";

        public Form1()
        {
            InitializeComponent();

            // Clear default selection highlight after data loads
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;

            // Populate Gender dropdown
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");

            // Populate Year Level dropdown
            cmbYear.Items.Add("1");
            cmbYear.Items.Add("2");
            cmbYear.Items.Add("3");
            cmbYear.Items.Add("4");

            // Populate Course dropdown
            cmbCourse.Items.Add("BSIT");
            cmbCourse.Items.Add("BSCpE");
            cmbCourse.Items.Add("BSA");
            cmbCourse.Items.Add("BSENTREP");
            cmbCourse.Items.Add("BSHM");
            cmbCourse.Items.Add("BSEd-EN");
            cmbCourse.Items.Add("BSEd-MT");
            cmbCourse.Items.Add("DOMT-LOM");

            LoadStudents();
            txtStudentID.Select();
        }

        private void LoadStudents()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM students";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    // Rename column headers for display
                    dataGridView1.Columns["student_id"].HeaderText = "Student ID";
                    dataGridView1.Columns["full_name"].HeaderText = "Full Name";
                    dataGridView1.Columns["date_of_birth"].HeaderText = "Date of Birth";
                    dataGridView1.Columns["gender"].HeaderText = "Gender";
                    dataGridView1.Columns["course"].HeaderText = "Course";
                    dataGridView1.Columns["year_level"].HeaderText = "Year Level";
                    dataGridView1.Columns["email"].HeaderText = "Email";
                    dataGridView1.Columns["phone_number"].HeaderText = "Phone";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Remove selection highlight once data binding is complete
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        private bool ValidateInputs()
        {
            // 1. Check for empty fields
            if (
                txtStudentID.Text == "" ||
                txtName.Text == "" ||
                cmbGender.Text == "" ||
                cmbCourse.Text == "" ||
                cmbYear.Text == "" ||
                txtEmail.Text == "" ||
                txtPhone.Text == ""
            )
            {
                MessageBox.Show("Please fill all fields.");
                return false;
            }

            // 2. Validate Student ID format (e.g., 2024-00175-SM-0)
            string idPattern = @"^\d{4}-\d{5}-[Ss][Mm]-\d$";
            if (!Regex.IsMatch(txtStudentID.Text, idPattern))
            {
                MessageBox.Show("Invalid Student ID format. Must be in the format: YYYY-NNNNN-SM-X (e.g., 2024-00175-SM-0)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 3. Validate phone number format (09xxxxxxxxx or +639xxxxxxxxx)
            string phonePattern = @"^(09|\+639)\d{9}$";
            if (!Regex.IsMatch(txtPhone.Text, phonePattern))
            {
                MessageBox.Show("Invalid Phone Number format. Please enter a valid 11-digit number starting with 09 (e.g., 09123456789) or use the +639 format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 4. Validate email address format
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txtStudentID.Clear();
            txtName.Clear();
            cmbGender.SelectedIndex = -1;
            cmbCourse.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            txtEmail.Clear();
            txtPhone.Clear();

            selectedStudentId = "";
            txtStudentID.Enabled = true; // Re-enable Student ID field for new entries
            dataGridView1.ClearSelection();

            txtStudentID.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO students
                    (student_id, full_name, date_of_birth, gender, course, year_level, email, phone_number)
                    VALUES
                    (@id, @name, @dob, @gender, @course, @year, @email, @phone)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Save Student ID in uppercase
                    cmd.Parameters.AddWithValue("@id", txtStudentID.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@course", cmbCourse.Text);
                    cmd.Parameters.AddWithValue("@year", cmbYear.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added Successfully!");
                    LoadStudents();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Duplicate entry"))
                {
                    MessageBox.Show("A student with this ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == "")
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE students SET
                    full_name=@name,
                    date_of_birth=@dob,
                    gender=@gender,
                    course=@course,
                    year_level=@year,
                    email=@email,
                    phone_number=@phone
                    WHERE student_id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", selectedStudentId);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@course", cmbCourse.Text);
                    cmd.Parameters.AddWithValue("@year", cmbYear.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated Successfully!");
                    LoadStudents();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == "")
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM students WHERE student_id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedStudentId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Student Deleted Successfully!");
                        LoadStudents();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
            ClearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedStudentId = row.Cells["student_id"].Value.ToString();
                txtStudentID.Text = selectedStudentId;

                // Disable Student ID field to prevent accidental edits during update
                txtStudentID.Enabled = false;

                txtName.Text = row.Cells["full_name"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(row.Cells["date_of_birth"].Value);
                cmbGender.Text = row.Cells["gender"].Value.ToString();
                cmbCourse.Text = row.Cells["course"].Value.ToString();
                cmbYear.Text = row.Cells["year_level"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPhone.Text = row.Cells["phone_number"].Value.ToString();
            }
        }
    }
}