CREATE DATABASE IF NOT EXISTS student_db;
USE student_db;

DROP TABLE IF EXISTS students;

CREATE TABLE students (
    student_id VARCHAR(20) PRIMARY KEY,
    full_name VARCHAR(100) NOT NULL,
    date_of_birth DATE NOT NULL,
    gender VARCHAR(10) NOT NULL,
    course VARCHAR(50) NOT NULL,
    year_level VARCHAR(10) NOT NULL,
    email VARCHAR(100) NOT NULL,
    phone_number VARCHAR(20) NOT NULL
);