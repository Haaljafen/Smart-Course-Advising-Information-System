using System;
using System.Windows.Forms;

namespace S6G2
{
    public partial class AcademicRecordForm : Form
    {
        private int StudentId;

        public AcademicRecordForm()
        {
            InitializeComponent();
        }

        public AcademicRecordForm(int studentId)
        {
            InitializeComponent();
            StudentId = studentId;
        }

        private void AcademicRecordForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCIAS_DBDataSet.Enrollments' table. You can move, or remove it, as needed.
            this.enrollmentsTableAdapter.Fill(this.sCIAS_DBDataSet.Enrollments);
            // TODO: This line of code loads data into the 'sCIAS_DBDataSet.Enrollments' table. You can move, or remove it, as needed.
            this.enrollmentsTableAdapter.Fill(this.sCIAS_DBDataSet.Enrollments);
            if (DesignMode) return;
            if (StudentId <= 0) return;

            dgvAcademicHistory.DataSource =
                AdviserService.GetAcademicRecord(StudentId);
            dgvAcademicHistory.ReadOnly = true;
            dgvAcademicHistory.AllowUserToAddRows = false;
            dgvAcademicHistory.AllowUserToDeleteRows = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}