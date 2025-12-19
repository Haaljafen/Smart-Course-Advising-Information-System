-- Create Database
USE master;
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'SCAIS_DB')
BEGIN
    ALTER DATABASE SCAIS_DB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE SCAIS_DB;
END
GO

CREATE DATABASE SCAIS_DB;
GO

USE SCAIS_DB;
GO

-- Table 1: users
CREATE TABLE users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) NOT NULL CHECK (Role IN ('Admin', 'Adviser', 'Student')),
    Email NVARCHAR(100),
    Status NVARCHAR(20) DEFAULT 'Active'
);

-- Table 2: advisers
CREATE TABLE advisers (
    AdviserID INT PRIMARY KEY IDENTITY(1,1),
    StaffNumber NVARCHAR(20) UNIQUE NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Department NVARCHAR(100),
    UserID INT FOREIGN KEY REFERENCES users(UserID),
    Status NVARCHAR(20) DEFAULT 'Active'
);

-- Table 3: specializations
CREATE TABLE specializations (
    SpecializationID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500),
    TotalCreditsRequired INT NOT NULL
);

-- Table 4: students
CREATE TABLE students (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    StudentNumber NVARCHAR(20) UNIQUE NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    IntakeSemester NVARCHAR(20),
    SpecializationID INT FOREIGN KEY REFERENCES specializations(SpecializationID),
    UserID INT FOREIGN KEY REFERENCES users(UserID),
    Status NVARCHAR(20) DEFAULT 'Active'
);

-- Table 5: semesters
CREATE TABLE semesters (
    SemesterID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL,
    AcademicYear NVARCHAR(20) NOT NULL,
    StartDate DATE,
    EndDate DATE
);

-- Table 6: courses
CREATE TABLE courses (
    CourseID INT PRIMARY KEY IDENTITY(1,1),
    CourseCode NVARCHAR(20) UNIQUE NOT NULL,
    CourseName NVARCHAR(200) NOT NULL,
    CreditHours INT NOT NULL,
    Level NVARCHAR(50),
    CourseType NVARCHAR(50) CHECK (CourseType IN ('Core', 'Specialized', 'Elective')),
    SpecializationID INT NULL FOREIGN KEY REFERENCES specializations(SpecializationID),
    IsActive BIT DEFAULT 1
);

-- Table 7: prerequisites
CREATE TABLE prerequisites (
    CourseID INT FOREIGN KEY REFERENCES courses(CourseID),
    RequiredCourseID INT FOREIGN KEY REFERENCES courses(CourseID),
    RequirementType NVARCHAR(50) CHECK (RequirementType IN ('Prerequisite', 'Corequisite')),
    PRIMARY KEY (CourseID, RequiredCourseID)
);

-- Table 8: course_offerings
CREATE TABLE course_offerings (
    OfferingID INT PRIMARY KEY IDENTITY(1,1),
    CourseID INT FOREIGN KEY REFERENCES courses(CourseID),
    SemesterID INT FOREIGN KEY REFERENCES semesters(SemesterID),
    Capacity INT,
    Status NVARCHAR(20) DEFAULT 'Open'
);

-- Table 9: enrollments
CREATE TABLE enrollments (
    EnrollmentID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT FOREIGN KEY REFERENCES students(StudentID),
    OfferingID INT FOREIGN KEY REFERENCES course_offerings(OfferingID),
    Status NVARCHAR(20) CHECK (Status IN ('Completed', 'In-Progress', 'Pending', 'Dropped')),
    Grade FLOAT NULL
);

-- Table 10: advising_plans
CREATE TABLE advising_plans (
    PlanID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT FOREIGN KEY REFERENCES students(StudentID),
    SemesterID INT FOREIGN KEY REFERENCES semesters(SemesterID),
    AdviserID INT FOREIGN KEY REFERENCES advisers(AdviserID),
    CreatedDate DATE DEFAULT GETDATE(),
    Status NVARCHAR(20) CHECK (Status IN ('Draft', 'Submitted', 'Approved', 'Rejected'))
);

-- Table 11: advising_plan_courses
CREATE TABLE advising_plan_courses (
    PlanID INT FOREIGN KEY REFERENCES advising_plans(PlanID),
    OfferingID INT FOREIGN KEY REFERENCES course_offerings(OfferingID),
    Decision NVARCHAR(20) CHECK (Decision IN ('Pending', 'Approved', 'Rejected')),
    AdviserRemark NVARCHAR(500),
    PRIMARY KEY (PlanID, OfferingID)
);

-- Table 12: advisee_assignments
CREATE TABLE advisee_assignments (
    AdviserID INT FOREIGN KEY REFERENCES advisers(AdviserID),
    StudentID INT FOREIGN KEY REFERENCES students(StudentID),
    AssignedDate DATE DEFAULT GETDATE(),
    IsPrimary BIT DEFAULT 1,
    PRIMARY KEY (AdviserID, StudentID)
);

GO