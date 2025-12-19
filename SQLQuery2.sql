USE SCAIS_DB;
GO

-- Insert Users (20 records)
INSERT INTO users (Username, PasswordHash, Role, Email, Status) VALUES
('admin1', 'hashed_password_1', 'Admin', 'admin1@bit.edu.bh', 'Active'),
('admin2', 'hashed_password_2', 'Admin', 'admin2@bit.edu.bh', 'Active'),
('adviser1', 'hashed_password_3', 'Adviser', 'adviser1@bit.edu.bh', 'Active'),
('adviser2', 'hashed_password_4', 'Adviser', 'adviser2@bit.edu.bh', 'Active'),
('adviser3', 'hashed_password_5', 'Adviser', 'adviser3@bit.edu.bh', 'Active'),
('student1', 'hashed_password_6', 'Student', 's2020001@student.bit.edu.bh', 'Active'),
('student2', 'hashed_password_7', 'Student', 's2020002@student.bit.edu.bh', 'Active'),
('student3', 'hashed_password_8', 'Student', 's2020003@student.bit.edu.bh', 'Active'),
('student4', 'hashed_password_9', 'Student', 's2021001@student.bit.edu.bh', 'Active'),
('student5', 'hashed_password_10', 'Student', 's2021002@student.bit.edu.bh', 'Active'),
('student6', 'hashed_password_11', 'Student', 's2021003@student.bit.edu.bh', 'Active'),
('student7', 'hashed_password_12', 'Student', 's2022001@student.bit.edu.bh', 'Active'),
('student8', 'hashed_password_13', 'Student', 's2022002@student.bit.edu.bh', 'Active'),
('student9', 'hashed_password_14', 'Student', 's2022003@student.bit.edu.bh', 'Active'),
('student10', 'hashed_password_15', 'Student', 's2023001@student.bit.edu.bh', 'Active'),
('student11', 'hashed_password_16', 'Student', 's2023002@student.bit.edu.bh', 'Active'),
('student12', 'hashed_password_17', 'Student', 's2023003@student.bit.edu.bh', 'Active'),
('adviser4', 'hashed_password_18', 'Adviser', 'adviser4@bit.edu.bh', 'Active'),
('adviser5', 'hashed_password_19', 'Adviser', 'adviser5@bit.edu.bh', 'Active'),
('student13', 'hashed_password_20', 'Student', 's2023004@student.bit.edu.bh', 'Active');

-- Insert Advisers (15 records)
INSERT INTO advisers (StaffNumber, FirstName, LastName, Department, UserID, Status) VALUES
('STF001', 'Ahmed', 'Al-Khalifa', 'Computer Science', 3, 'Active'),
('STF002', 'Fatima', 'Al-Mansoori', 'Information Technology', 4, 'Active'),
('STF003', 'Mohammed', 'Al-Dosari', 'Computer Science', 5, 'Active'),
('STF004', 'Layla', 'Al-Kuwari', 'Information Technology', 18, 'Active'),
('STF005', 'Khalid', 'Al-Thani', 'Computer Science', 19, 'Active'),
('STF006', 'Noora', 'Al-Baker', 'Information Technology', NULL, 'Active'),
('STF007', 'Salman', 'Al-Mutawa', 'Computer Science', NULL, 'Active'),
('STF008', 'Hessa', 'Al-Rumaihi', 'Information Technology', NULL, 'Active'),
('STF009', 'Rashid', 'Al-Sulaiti', 'Computer Science', NULL, 'Active'),
('STF010', 'Maryam', 'Al-Saad', 'Information Technology', NULL, 'Active'),
('STF011', 'Abdulla', 'Al-Mohannadi', 'Computer Science', NULL, 'Active'),
('STF012', 'Sara', 'Al-Kaabi', 'Information Technology', NULL, 'Active'),
('STF013', 'Hamad', 'Al-Attiyah', 'Computer Science', NULL, 'Active'),
('STF014', 'Aisha', 'Al-Naimi', 'Information Technology', NULL, 'Active'),
('STF015', 'Jassim', 'Al-Marri', 'Computer Science', NULL, 'Active');

-- Insert Specializations (4 records)
INSERT INTO specializations (Name, Description, TotalCreditsRequired) VALUES
('Programming', 'Focuses on software development, algorithms, and application design', 120),
('Networking', 'Focuses on network infrastructure, protocols, and communications', 120),
('Cybersecurity', 'Focuses on security principles, threat analysis, and defense mechanisms', 120),
('Database', 'Focuses on database design, administration, and data management', 120);

-- Insert Students (15 records)
INSERT INTO students (StudentNumber, FirstName, LastName, IntakeSemester, SpecializationID, UserID, Status) VALUES
('202000123', 'Omar', 'Hassan', 'Fall 2020', 1, 6, 'Active'),
('202000145', 'Reem', 'Abdullah', 'Fall 2020', 2, 7, 'Active'),
('202000167', 'Yousef', 'Mohamed', 'Fall 2020', 3, 8, 'Active'),
('202100234', 'Noor', 'Ali', 'Spring 2021', 4, 9, 'Active'),
('202100256', 'Tariq', 'Ibrahim', 'Spring 2021', 1, 10, 'Active'),
('202100278', 'Shamma', 'Khalid', 'Spring 2021', 2, 11, 'Active'),
('202200345', 'Hamza', 'Saeed', 'Fall 2022', 3, 12, 'Active'),
('202200367', 'Amna', 'Rashid', 'Fall 2022', 4, 13, 'Active'),
('202200389', 'Sultan', 'Ahmed', 'Fall 2022', 1, 14, 'Active'),
('202300456', 'Lulwa', 'Mahmoud', 'Spring 2023', 2, 15, 'Active'),
('202300478', 'Majid', 'Youssef', 'Spring 2023', 3, 16, 'Active'),
('202300490', 'Hind', 'Karim', 'Spring 2023', 4, 17, 'Active'),
('202300512', 'Fahad', 'Nasser', 'Spring 2023', 1, 20, 'Active'),
('202100298', 'Dana', 'Salem', 'Spring 2021', 2, NULL, 'Active'),
('202200401', 'Saud', 'Omar', 'Fall 2022', 3, NULL, 'Active');

-- Insert Semesters (15 records)
INSERT INTO semesters (Name, AcademicYear, StartDate, EndDate) VALUES
('Fall 2020', '2020-2021', '2020-09-01', '2020-12-20'),
('Spring 2021', '2020-2021', '2021-01-10', '2021-05-15'),
('Summer 2021', '2020-2021', '2021-06-01', '2021-07-30'),
('Fall 2021', '2021-2022', '2021-09-01', '2021-12-20'),
('Spring 2022', '2021-2022', '2022-01-10', '2022-05-15'),
('Summer 2022', '2021-2022', '2022-06-01', '2022-07-30'),
('Fall 2022', '2022-2023', '2022-09-01', '2022-12-20'),
('Spring 2023', '2022-2023', '2023-01-10', '2023-05-15'),
('Summer 2023', '2022-2023', '2023-06-01', '2023-07-30'),
('Fall 2023', '2023-2024', '2023-09-01', '2023-12-20'),
('Spring 2024', '2023-2024', '2024-01-10', '2024-05-15'),
('Summer 2024', '2023-2024', '2024-06-01', '2024-07-30'),
('Fall 2024', '2024-2025', '2024-09-01', '2024-12-20'),
('Spring 2025', '2024-2025', '2025-01-10', '2025-05-15'),
('Summer 2025', '2024-2025', '2025-06-01', '2025-07-30');

-- Insert Courses (25 records - Core + Specialized)
INSERT INTO courses (CourseCode, CourseName, CreditHours, Level, CourseType, SpecializationID, IsActive) VALUES
-- Core Courses (All students)
('CS101', 'Computer Systems', 3, 'Level 1', 'Core', NULL, 1),
('MATH101', 'Math for Computing', 3, 'Level 1', 'Core', NULL, 1),
('CS102', 'Unix Systems', 3, 'Level 1', 'Core', NULL, 1),
('CS201', 'Programming Fundamentals', 3, 'Level 2', 'Core', NULL, 1),
('CS202', 'Data Structures', 3, 'Level 2', 'Core', NULL, 1),
('CS301', 'Database 1', 3, 'Level 3', 'Core', NULL, 1),
('CS302', 'Networking Fundamentals', 3, 'Level 3', 'Core', NULL, 1),
('CS401', 'Software Engineering', 3, 'Level 4', 'Core', NULL, 1),

-- Programming Specialization
('PROG301', 'Object Oriented Design', 3, 'Level 3', 'Specialized', 1, 1),
('PROG302', 'Advanced Programming', 3, 'Level 3', 'Specialized', 1, 1),
('PROG401', 'Web Development', 3, 'Level 4', 'Specialized', 1, 1),
('PROG402', 'Mobile App Development', 3, 'Level 4', 'Specialized', 1, 1),

-- Networking Specialization
('NET301', 'Wireless Communication', 3, 'Level 3', 'Specialized', 2, 1),
('NET302', 'Advanced Networking', 3, 'Level 3', 'Specialized', 2, 1),
('NET401', 'Network and Data Communications 2', 3, 'Level 4', 'Specialized', 2, 1),
('NET402', 'Network Security', 3, 'Level 4', 'Specialized', 2, 1),

-- Cybersecurity Specialization
('CYB301', 'Defense in Depth', 3, 'Level 3', 'Specialized', 3, 1),
('CYB302', 'Ethical Hacking', 3, 'Level 3', 'Specialized', 3, 1),
('CYB401', 'Cryptography', 3, 'Level 4', 'Specialized', 3, 1),
('CYB402', 'Incident Response', 3, 'Level 4', 'Specialized', 3, 1),

-- Database Specialization
('DB301', 'Database Administration', 3, 'Level 3', 'Specialized', 4, 1),
('DB302', 'Database 2', 3, 'Level 3', 'Specialized', 4, 1),
('DB401', 'Data Warehousing', 3, 'Level 4', 'Specialized', 4, 1),
('DB402', 'Big Data Analytics', 3, 'Level 4', 'Specialized', 4, 1),
('CS403', 'Project Management', 3, 'Level 4', 'Core', NULL, 1);

-- Insert Prerequisites (15+ records)
INSERT INTO prerequisites (CourseID, RequiredCourseID, RequirementType) VALUES
-- Core prerequisites
(5, 4, 'Prerequisite'),  -- Data Structures requires Programming Fundamentals
(6, 5, 'Prerequisite'),  -- Database 1 requires Data Structures
(7, 1, 'Prerequisite'),  -- Networking Fundamentals requires Computer Systems
(8, 5, 'Prerequisite'),  -- Software Engineering requires Data Structures

-- Programming prerequisites
(9, 4, 'Prerequisite'),  -- OOD requires Programming Fundamentals
(10, 9, 'Prerequisite'), -- Advanced Programming requires OOD
(11, 9, 'Prerequisite'), -- Web Development requires OOD
(12, 10, 'Prerequisite'), -- Mobile App Dev requires Advanced Programming

-- Networking prerequisites
(14, 7, 'Prerequisite'), -- Advanced Networking requires Networking Fundamentals
(15, 14, 'Prerequisite'), -- Network and Data Comm 2 requires Advanced Networking
(16, 14, 'Prerequisite'), -- Network Security requires Advanced Networking
(13, 7, 'Prerequisite'), -- Wireless Communication requires Networking Fundamentals

-- Cybersecurity prerequisites
(17, 7, 'Prerequisite'), -- Defense in Depth requires Networking Fundamentals
(18, 17, 'Prerequisite'), -- Ethical Hacking requires Defense in Depth
(19, 17, 'Prerequisite'), -- Cryptography requires Defense in Depth
(20, 18, 'Prerequisite'), -- Incident Response requires Ethical Hacking

-- Database prerequisites
(22, 6, 'Prerequisite'), -- Database 2 requires Database 1
(21, 6, 'Prerequisite'), -- Database Administration requires Database 1
(23, 22, 'Prerequisite'), -- Data Warehousing requires Database 2
(24, 22, 'Prerequisite'); -- Big Data Analytics requires Database 2

-- Insert Course Offerings (20+ records)
INSERT INTO course_offerings (CourseID, SemesterID, Capacity, Status) VALUES
-- Fall 2024 offerings
(1, 13, 30, 'Open'),
(2, 13, 30, 'Open'),
(3, 13, 30, 'Open'),
(4, 13, 30, 'Open'),
(5, 13, 25, 'Open'),
(6, 13, 25, 'Open'),
(7, 13, 25, 'Open'),

-- Spring 2025 offerings
(1, 14, 30, 'Open'),
(4, 14, 30, 'Open'),
(5, 14, 25, 'Open'),
(6, 14, 25, 'Open'),
(8, 14, 20, 'Open'),
(9, 14, 20, 'Open'),
(10, 14, 20, 'Open'),
(13, 14, 20, 'Open'),
(17, 14, 20, 'Open'),
(21, 14, 20, 'Open'),

-- Past offerings (Fall 2023)
(1, 10, 30, 'Closed'),
(2, 10, 30, 'Closed'),
(4, 10, 30, 'Closed'),

-- More offerings
(11, 14, 15, 'Open'),
(15, 14, 15, 'Open'),
(19, 14, 15, 'Open'),
(23, 14, 15, 'Open');

-- Insert Enrollments (20+ records)
INSERT INTO enrollments (StudentID, OfferingID, Status, Grade) VALUES
-- Student 1 (Programming track) - Completed courses
(1, 18, 'Completed', 85.5),
(1, 19, 'Completed', 78.0),
(1, 20, 'Completed', 88.5),
(1, 1, 'In-Progress', NULL),
(1, 5, 'In-Progress', NULL),

-- Student 2 (Networking track) - Completed courses
(2, 18, 'Completed', 90.0),
(2, 19, 'Completed', 82.5),
(2, 20, 'Completed', 85.0),
(2, 2, 'In-Progress', NULL),
(2, 6, 'In-Progress', NULL),

-- Student 3 (Cybersecurity track) - Completed courses
(3, 18, 'Completed', 77.5),
(3, 19, 'Completed', 80.0),
(3, 20, 'Completed', 83.5),
(3, 3, 'In-Progress', NULL),

-- Student 4 (Database track)
(4, 18, 'Completed', 92.0),
(4, 19, 'Completed', 88.0),
(4, 8, 'In-Progress', NULL),

-- More students
(5, 18, 'Completed', 75.0),
(5, 9, 'In-Progress', NULL),
(6, 18, 'Completed', 81.0),
(6, 10, 'In-Progress', NULL),
(7, 11, 'In-Progress', NULL);

-- Insert Advising Plans (15 records)
INSERT INTO advising_plans (StudentID, SemesterID, AdviserID, CreatedDate, Status) VALUES
(1, 14, 1, '2024-12-01', 'Approved'),
(2, 14, 1, '2024-12-01', 'Approved'),
(3, 14, 2, '2024-12-02', 'Approved'),
(4, 14, 2, '2024-12-02', 'Approved'),
(5, 14, 3, '2024-12-03', 'Submitted'),
(6, 14, 3, '2024-12-03', 'Submitted'),
(7, 14, 4, '2024-12-04', 'Draft'),
(8, 14, 4, '2024-12-04', 'Draft'),
(9, 14, 5, '2024-12-05', 'Rejected'),
(10, 14, 1, '2024-12-05', 'Approved'),
(11, 14, 2, '2024-12-06', 'Approved'),
(12, 14, 3, '2024-12-06', 'Submitted'),
(13, 14, 4, '2024-12-07', 'Draft'),
(1, 13, 1, '2024-08-15', 'Approved'),
(2, 13, 1, '2024-08-15', 'Approved');

-- Insert Advising Plan Courses (20+ records)
INSERT INTO advising_plan_courses (PlanID, OfferingID, Decision, AdviserRemark) VALUES
(1, 1, 'Approved', 'Good choice for this semester'),
(1, 5, 'Approved', 'Ensure you complete prerequisites'),
(2, 2, 'Approved', 'Excellent progress'),
(2, 6, 'Approved', NULL),
(3, 3, 'Approved', 'Focus on security fundamentals'),
(3, 12, 'Approved', NULL),
(4, 8, 'Approved', 'Database track progressing well'),
(4, 16, 'Approved', NULL),
(5, 9, 'Pending', 'Waiting for prerequisite verification'),
(5, 13, 'Pending', NULL),
(6, 10, 'Pending', NULL),
(7, 11, 'Pending', NULL),
(8, 14, 'Pending', NULL),
(9, 15, 'Rejected', 'Prerequisites not met'),
(10, 1, 'Approved', NULL),
(11, 2, 'Approved', NULL),
(12, 3, 'Pending', NULL),
(13, 4, 'Pending', NULL),
(14, 1, 'Approved', 'Previous semester plan'),
(15, 2, 'Approved', 'Previous semester plan');

-- Insert Advisee Assignments (15 records)
INSERT INTO advisee_assignments (AdviserID, StudentID, AssignedDate, IsPrimary) VALUES
(1, 1, '2020-09-01', 1),
(1, 2, '2020-09-01', 1),
(2, 3, '2020-09-01', 1),
(2, 4, '2021-01-10', 1),
(3, 5, '2021-01-10', 1),
(3, 6, '2021-01-10', 1),
(4, 7, '2022-09-01', 1),
(4, 8, '2022-09-01', 1),
(5, 9, '2022-09-01', 1),
(1, 10, '2023-01-10', 1),
(2, 11, '2023-01-10', 1),
(3, 12, '2023-01-10', 1),
(4, 13, '2023-01-10', 1),
(5, 14, '2021-01-10', 1),
(1, 15, '2022-09-01', 1);

GO

PRINT 'Database and mock data created successfully!';