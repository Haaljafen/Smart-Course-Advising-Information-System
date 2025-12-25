using System;
using System.Data;
using System.Data.SqlClient;

namespace S6G2
{
    public static class AdviserService
    {
        // ================= STUDENTS =================
        public static DataTable GetAssignedStudents(int adviserId)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(
                Properties.Settings.Default.SCIAS_DBConnectionString))
            {
                string query = @" 
            -- 👇 SQL QUERY GOES HERE
        ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AdviserID", adviserId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        // ================= ACADEMIC RECORD =================
        public static DataTable GetAcademicRecord(int studentId)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(
                Properties.Settings.Default.SCIAS_DBConnectionString))
            {
                string query = @"
            SELECT 
                c.CourseCode,
                c.CourseName,
                e.Semester,
                e.Grade,
                e.Status
            FROM Enrollments e
            INNER JOIN Courses c ON e.CourseID = c.CourseID
            WHERE e.StudentID = @StudentID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentID", studentId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        // ================= STUDENT PLAN =================
        public static DataTable GetStudentPlan(int studentId)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(
                Properties.Settings.Default.SCIAS_DBConnectionString))
            {
                string query = @"
        SELECT
            c.CourseCode,
            c.CourseName,
            c.CreditHours,
            apc.CourseType
        FROM Advising_Plans ap
        INNER JOIN Advising_Plan_Courses apc ON ap.PlanID = apc.PlanID
        INNER JOIN Courses c ON apc.CourseID = c.CourseID
        WHERE ap.StudentID = @StudentID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentID", studentId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        // ================= ELIGIBLE COURSES =================
        public static DataTable GetEligibleCourses(int studentId)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(
                Properties.Settings.Default.SCIAS_DBConnectionString))
            {
                string query = @"
        SELECT
            c.CourseCode,
            c.CourseName,
            c.CreditHours,
            c.CourseType
        FROM Courses c
        WHERE c.CourseID NOT IN
        (
            SELECT e.CourseID
            FROM Enrollments e
            WHERE e.StudentID = @StudentID
              AND e.Status = 'Completed'
        )";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentID", studentId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        // ================= PROGRESS REPORT =================
        public static ProgressReport GenerateProgressReport(int studentId)
        {
            ProgressReport report = new ProgressReport();

            using (SqlConnection con = new SqlConnection(
                Properties.Settings.Default.SCIAS_DBConnectionString))
            {
                string query = @"
            SELECT 
                ISNULL(SUM(c.CreditHours),0) AS CompletedCredits
            FROM Enrollments e
            INNER JOIN Courses c ON e.CourseID = c.CourseID
            WHERE e.StudentID = @StudentID
              AND e.Status = 'Completed'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentID", studentId);

                con.Open();
                int completed = Convert.ToInt32(cmd.ExecuteScalar());

                report.CompletedCredits = completed;

                // Example total required credits
                int totalRequired = 120;
                report.RemainingCredits = totalRequired - completed;
            }

            return report;
        }

        // ================= APPROVE / REJECT =================
        public static void ApprovePlan(int studentId, int adviserId)
        {
            using (SqlConnection con = new SqlConnection(
                Properties.Settings.Default.SCIAS_DBConnectionString))
            {
                string query = @"
        UPDATE Advising_Plans
        SET Status = 'Approved'
        WHERE StudentID = @StudentID
          AND AdviserID = @AdviserID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@AdviserID", adviserId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void RejectPlan(int studentId, int adviserId, string remark)
        {
            using (SqlConnection con = new SqlConnection(
                Properties.Settings.Default.SCIAS_DBConnectionString))
            {
                string query = @"
        UPDATE Advising_Plans
        SET Status = 'Rejected',
            AdviserRemark = @Remark
        WHERE StudentID = @StudentID
          AND AdviserID = @AdviserID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@AdviserID", adviserId);
                cmd.Parameters.AddWithValue("@Remark", remark);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}