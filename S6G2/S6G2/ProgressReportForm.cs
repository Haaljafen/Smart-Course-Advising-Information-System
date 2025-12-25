using System;
using System.Windows.Forms;

namespace S6G2
{
    public partial class ProgressReportForm : Form
    {
        private int StudentId;

        public ProgressReportForm()
        {
            InitializeComponent();
        }

        public ProgressReportForm(int studentId)
        {
            InitializeComponent();
            StudentId = studentId;
        }

        private void ProgressReportForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (StudentId <= 0) return;

            ProgressReport report =
                AdviserService.GenerateProgressReport(StudentId);

            lblCompleted.Text = report.CompletedCredits.ToString();
            lblRemaining.Text = report.RemainingCredits.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}