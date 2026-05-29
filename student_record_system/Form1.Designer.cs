namespace student_record_system
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblYearLevel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(214, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(800, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(800, 171);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(235, 22);
            this.txtPhone.TabIndex = 4;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(214, 173);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(236, 24);
            this.cmbGender.TabIndex = 5;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(214, 124);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(236, 22);
            this.dtpDOB.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(56, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(59, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 31);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(164, 261);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 28);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(169, 298);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 28);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1228, 305);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(48, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Full Name:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(48, 122);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(124, 20);
            this.lblDOB.TabIndex = 13;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(55, 171);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(70, 20);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(668, 48);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(75, 20);
            this.lblCourse.TabIndex = 15;
            this.lblCourse.Text = "Course:";
            // 
            // lblYearLevel
            // 
            this.lblYearLevel.AutoSize = true;
            this.lblYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearLevel.Location = new System.Drawing.Point(668, 84);
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(53, 20);
            this.lblYearLevel.TabIndex = 16;
            this.lblYearLevel.Text = "Year:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(668, 124);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 20);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(668, 173);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(95, 20);
            this.lblPhoneNumber.TabIndex = 18;
            this.lblPhoneNumber.Text = "Phone No.";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(48, 46);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(104, 20);
            this.lblStudentID.TabIndex = 19;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(214, 46);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(236, 22);
            this.txtStudentID.TabIndex = 21;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(799, 86);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(236, 24);
            this.cmbYear.TabIndex = 22;
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(799, 46);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(236, 24);
            this.cmbCourse.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 679);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblYearLevel);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbCourse;
    }
}

