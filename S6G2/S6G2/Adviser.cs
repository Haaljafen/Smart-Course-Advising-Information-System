using System;
using System.Windows.Forms;

namespace S6G2
{
    public partial class Adviser : Form
    {
        private int CurrentAdviserId;

        public Adviser()
        {
            InitializeComponent();
        }

        public Adviser(int adviserId)
        {
            InitializeComponent();
            CurrentAdviserId = adviserId;
        }

        private void Adviser_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            dgvStudents.DataSource =
                AdviserService.GetAssignedStudents(CurrentAdviserId);

            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.AllowUserToAddRows = false;
        }

        private int GetSelectedStudentId()
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student.");
                return -1;
            }

            return Convert.ToInt32(
                dgvStudents.SelectedRows[0].Cells["StudentID"].Value);
        }

        private void btnViewPlan_Click(object sender, EventArgs e)
        {
            int studentId = GetSelectedStudentId();
            if (studentId == -1) return;

            new AdviserStudentsForm(studentId, CurrentAdviserId).ShowDialog();
        }

        private void btnAcademicRecord_Click(object sender, EventArgs e)
        {
            int studentId = GetSelectedStudentId();
            if (studentId == -1) return;

            new AcademicRecordForm(studentId).ShowDialog();
        }

        private void btnRecommendCourse_Click(object sender, EventArgs e)
        {
            int studentId = GetSelectedStudentId();
            if (studentId == -1) return;

            new RecommendCourseForm(studentId).ShowDialog();
        }

        private void btnProgressReport_Click(object sender, EventArgs e)
        {
            int studentId = GetSelectedStudentId();
            if (studentId == -1) return;

            new ProgressReportForm(studentId).ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Form1"]?.Show();
        }
    }
}