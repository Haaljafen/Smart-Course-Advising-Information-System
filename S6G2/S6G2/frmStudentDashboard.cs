using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace S6G2
{
    public partial class frmStudentDashboard : Form
    {
        public frmStudentDashboard()
        {
            InitializeComponent();
            SetupNavigation();
        }

        private void SetupNavigation()
        {
            btnAcademicRecord.Click += (s, e) =>
            {
                SwitchTo(pnlAcademicRecord, btnAcademicRecord);
                LoadAcademicRecord();
            };

            btnEligibleCourses.Click += (s, e) =>
            {
                SwitchTo(pnlEligibleCourses, btnEligibleCourses);
                LoadEligibleCourses();
            };

            btnSubmitPlan.Click += (s, e) =>
            {
                SwitchTo(pnlSubmitPlan, btnSubmitPlan);
                LoadSelectableOfferings();
            };


            btnApprovedPlan.Click += (s, e) =>
            {
                SwitchTo(pnlApproved, btnApprovedPlan);
                //LoadApprovedPlan();
            };
        }


        private void SwitchTo(Panel panelToShow, Button activeButton)
        {
            // hide panels
            pnlAcademicRecord.Visible = false;
            pnlEligibleCourses.Visible = false;
            pnlSubmitPlan.Visible = false;
            pnlApproved.Visible = false;

            // show panel
            panelToShow.Visible = true;

            // highlight active button (simple)
            Button[] buttons = { btnAcademicRecord, btnEligibleCourses, btnSubmitPlan, btnApprovedPlan };
            foreach (var b in buttons)
            {
                b.BackColor = Color.White;
                b.Font = new Font(b.Font, FontStyle.Regular);
            }

            activeButton.BackColor = Color.Gainsboro;
            activeButton.Font = new Font(activeButton.Font, FontStyle.Bold);
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAcademicRecord_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlEligibleCourses_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlApproved_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmStudentDashboard_Load(object sender, EventArgs e)
        {

        }

        private void lblRecordTitle_Click(object sender, EventArgs e)
        {

        }

        private void LoadSelectableOfferings()
        {
            using (var conn = Db.GetConn())
            using (var cmd = new SqlCommand(@"
        SELECT 
            co.OfferingID,
            c.CourseCode AS [Code],
            c.CourseName AS [Course],
            s.Name       AS [Semester]
        FROM course_offerings co
        INNER JOIN courses c ON c.CourseID = co.CourseID
        INNER JOIN semesters s ON s.SemesterID = co.SemesterID
        ORDER BY s.SemesterID DESC, c.CourseCode;
    ", conn))
            {
                var dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                dgvSelect.DataSource = dt;

                EnsurePickColumn();

                // keep OfferingID hidden but still accessible in code
                dgvSelect.Columns["OfferingID"].Visible = false;
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1) collect selected OfferingIDs
            var offeringIds = new List<int>();

            foreach (DataGridViewRow row in dgvSelect.Rows)
            {
                if (row.IsNewRow) continue;

                bool picked = row.Cells["Pick"].Value != null && (bool)row.Cells["Pick"].Value;

                if (picked)
                {
                    int offeringId = Convert.ToInt32(row.Cells["OfferingID"].Value);
                    offeringIds.Add(offeringId);
                }
            }

            if (offeringIds.Count == 0)
            {
                MessageBox.Show("Please pick at least one course.");
                return;
            }

            // 2) insert advising plan + plan courses
            using (var conn = Db.GetConn())
            {
                conn.Open();
                using (var tx = conn.BeginTransaction())
                {
                    try
                    {
                        int planId;

                        // Create a plan (choose a semester id)
                        // For now: use the semester of the FIRST selected offering
                        int semesterId;
                        using (var cmdSem = new SqlCommand(@"
                    SELECT SemesterID FROM course_offerings WHERE OfferingID = @oid;
                ", conn, tx))
                        {
                            cmdSem.Parameters.AddWithValue("@oid", offeringIds[0]);
                            semesterId = Convert.ToInt32(cmdSem.ExecuteScalar());
                        }

                        using (var cmdPlan = new SqlCommand(@"
                    INSERT INTO advising_plans (StudentID, SemesterID, CreatedDate, Status, AdviserID)
                    OUTPUT INSERTED.PlanID
                    VALUES (@sid, @sem, GETDATE(), 'Pending', NULL);
                ", conn, tx))
                        {
                            cmdPlan.Parameters.AddWithValue("@sid", StudentSession.StudentId);
                            cmdPlan.Parameters.AddWithValue("@sem", semesterId);
                            planId = (int)cmdPlan.ExecuteScalar();
                        }

                        // Insert selected offerings
                        foreach (var oid in offeringIds)
                        {
                            using (var cmdItem = new SqlCommand(@"
                        INSERT INTO advising_plan_courses (PlanID, OfferingID, Decision, AdviserRemark)
                        VALUES (@pid, @oid, 'Pending', NULL);
                    ", conn, tx))
                            {
                                cmdItem.Parameters.AddWithValue("@pid", planId);
                                cmdItem.Parameters.AddWithValue("@oid", oid);
                                cmdItem.ExecuteNonQuery();
                            }
                        }

                        tx.Commit();
                        MessageBox.Show("✅ Plan submitted successfully!");

                        // refresh page after submit
                        LoadSelectableOfferings();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        MessageBox.Show("❌ Submit failed:\n" + ex.Message);
                    }
                }
            }
        }

        private void EnsurePickColumn()
        {
            if (dgvSelect.Columns["Pick"] == null)
            {
                var pick = new DataGridViewCheckBoxColumn
                {
                    Name = "Pick",
                    HeaderText = "Pick"
                };
                dgvSelect.Columns.Insert(0, pick);
            }
        }

        private void LoadEligibleCourses()
        {
            using (var conn = Db.GetConn())
            using (var cmd = new SqlCommand(@"
        SELECT 
            co.OfferingID,
            c.CourseCode AS [Code],
            c.CourseName AS [Course],
            s.Name       AS [Semester]
        FROM course_offerings co
        INNER JOIN courses c ON c.CourseID = co.CourseID
        INNER JOIN semesters s ON s.SemesterID = co.SemesterID
        WHERE co.Status = 'Open'
          AND co.OfferingID NOT IN (
              SELECT e.OfferingID
              FROM enrollments e
              WHERE e.StudentID = @sid
          )
        ORDER BY s.SemesterID DESC, c.CourseCode;
    ", conn))
            {
                cmd.Parameters.AddWithValue("@sid", StudentSession.StudentId);

                var dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                dgvEligible.DataSource = dt;

                if (dgvEligible.Columns.Contains("OfferingID"))
                    dgvEligible.Columns["OfferingID"].Visible = false;
            }
        }

        private void LoadAcademicRecord()
        {
            using (var conn = Db.GetConn())
            using (var cmd = new SqlCommand(@"
        SELECT 
            c.CourseCode  AS [Code],
            c.CourseName  AS [Course],
            e.Status      AS [Status],
            e.Grade       AS [Grade],
            s.Name        AS [Semester]
        FROM enrollments e
        INNER JOIN course_offerings co ON co.OfferingID = e.OfferingID
        INNER JOIN courses c ON c.CourseID = co.CourseID
        INNER JOIN semesters s ON s.SemesterID = co.SemesterID
        WHERE e.StudentID = @sid
        ORDER BY s.AcademicYear DESC, s.SemesterID DESC;
    ", conn))
            {
                cmd.Parameters.AddWithValue("@sid", StudentSession.StudentId);

                var dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                dgvRecord.DataSource = dt;
            }
        }



        private void dgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblRecordTitle_Click_1(object sender, EventArgs e)
        {

        }
        private void frmStudentDashboard_Load_1(object sender, EventArgs e)
        {
            StudentSession.StudentId = 1; // change to a real student id that exists
            StudentSession.Email = "test@student.com";
            lblWelcome.Text = "Welcome, " + StudentSession.Email;
            SwitchTo(pnlAcademicRecord, btnAcademicRecord);
            LoadAcademicRecord();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}
