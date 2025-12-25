using System;
using System.Windows.Forms;

namespace S6G2
{
    public partial class RecommendCourseForm : Form
    {
        private int StudentId;

        public RecommendCourseForm()
        {
            InitializeComponent();
        }

        public RecommendCourseForm(int studentId)
        {
            InitializeComponent();
            StudentId = studentId;
        }

        private void RecommendCourseForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (StudentId <= 0) return;

            dgvCourses.DataSource =
                AdviserService.GetEligibleCourses(StudentId);

            dgvCourses.ReadOnly = true;
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRecoomend_Click(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to recommend.");
                return;
            }

            MessageBox.Show(
                "Course recommended successfully.",
                "Recommendation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}