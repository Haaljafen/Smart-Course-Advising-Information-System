using System;
using System.Data;
using System.Windows.Forms;

namespace S6G2
{
    public partial class AdviserStudentsForm : Form
    {
        private int CurrentStudentId;
        private int CurrentAdviserId;

        public AdviserStudentsForm()
        {
            InitializeComponent();
        }

        public AdviserStudentsForm(int studentId, int adviserId)
        {
            InitializeComponent();
            CurrentStudentId = studentId;
            CurrentAdviserId = adviserId;
        }

        private void AdviserStudentsForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            dgvCourses.DataSource =
                AdviserService.GetStudentPlan(CurrentStudentId);

            dgvCourses.ReadOnly = true;
            dgvCourses.AllowUserToAddRows = false;
        }

        private void LoadPlanCourses()
        {
            dgvCourses.DataSource =
                AdviserService.GetStudentPlan(CurrentStudentId);

            dgvCourses.ReadOnly = true;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            AdviserService.ApprovePlan(CurrentStudentId, CurrentAdviserId);
            MessageBox.Show("Plan approved");
            Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            AdviserService.RejectPlan(CurrentStudentId, CurrentAdviserId, "Review");
            MessageBox.Show("Plan rejected");
            Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modify logic can be added later.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}