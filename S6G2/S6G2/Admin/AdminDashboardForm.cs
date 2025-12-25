using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace S6G2.Admain
{
    public partial class AdminDashboardForm : Form
    {

        string connectionString = ConfigurationManager
    .ConnectionStrings["S6G2.Properties.Settings.SCIAS_DBConnectionString"]
    .ConnectionString;

        public AdminDashboardForm()
        {
            InitializeComponent();

            dgvCourses.AutoGenerateColumns = false;

            LoadSpecializations();
            BindSpecializationColumn();
            LoadCourses();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HideAllPanels()
        {
            panelCourses.Visible = false;
            panelStudents.Visible = false;
            panelAdvisors.Visible = false;
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelCourses.Visible = true;
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelStudents.Visible = true;
        }

        private void btnAdvisors_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelAdvisors.Visible = true;
        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCourses.Rows[e.RowIndex];

            txtCourseId.Text = row.Cells["CourseID"].Value?.ToString() ?? "";
            txtCourseCode.Text = row.Cells["CourseCode"].Value?.ToString() ?? "";
            txtCourseName.Text = row.Cells["CourseName"].Value?.ToString() ?? "";
            txtCredits.Text = row.Cells["CreditHours"].Value?.ToString() ?? "";
            txtLevel.Text = row.Cells["Level"].Value?.ToString() ?? "";
            txtCourseType.Text = row.Cells["CourseType"].Value?.ToString() ?? "";

            if (row.Cells["IsActive"].Value != DBNull.Value)
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
            else
                chkIsActive.Checked = false;


            if (row.Cells["Specialization"].Value != DBNull.Value)
                cmbSpecialization.SelectedValue = row.Cells["Specialization"].Value;
            else
                cmbSpecialization.SelectedIndex = -1;

        }

        private void dgvCourses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }


        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (!ValidateCourseForm())
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO Courses
            (CourseID, CourseCode, CourseName, CreditHours, Level, CourseType, IsActive, SpecializationID)
            VALUES
            (@id, @code, @name, @credits, @level, @type, @active, @specId)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtCourseId.Text));
                cmd.Parameters.AddWithValue("@code", txtCourseCode.Text);
                cmd.Parameters.AddWithValue("@name", txtCourseName.Text);
                cmd.Parameters.AddWithValue("@credits", int.Parse(txtCredits.Text));
                cmd.Parameters.AddWithValue("@level", int.Parse(txtLevel.Text));
                cmd.Parameters.AddWithValue("@type", txtCourseType.Text);
                cmd.Parameters.AddWithValue("@active", chkIsActive.Checked);
                cmd.Parameters.AddWithValue("@specId", cmbSpecialization.SelectedValue);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Course added successfully");
            LoadCourses();
            ClearCourseFields();
        }

        private void BindSpecializationColumn()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT SpecializationID, Name FROM Specializations", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                var col = (DataGridViewComboBoxColumn)dgvCourses.Columns["Specialization"];
                col.DataSource = dt;
                col.DisplayMember = "Name";
                col.ValueMember = "SpecializationID";
            }
        }


        private void LoadCourses()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                CourseID,
                CourseCode,
                CourseName,
                CreditHours,
                Level,
                CourseType,
                IsActive,
                SpecializationID
            FROM Courses";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCourses.DataSource = dt;
            }
        }

        private void LoadSpecializations()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SpecializationID, Name FROM Specializations";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbSpecialization.DataSource = dt;
                cmbSpecialization.DisplayMember = "Name";
                cmbSpecialization.ValueMember = "SpecializationID";
            }
        }


        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseId.Text))
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        UPDATE Courses SET
            CourseCode = @code,
            CourseName = @name,
            CreditHours = @credits,
            Level = @level,
            CourseType = @type,
            IsActive = @active,
            SpecializationID = @specId
        WHERE CourseID = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtCourseId.Text));
                cmd.Parameters.AddWithValue("@code", txtCourseCode.Text);
                cmd.Parameters.AddWithValue("@name", txtCourseName.Text);
                cmd.Parameters.AddWithValue("@credits", int.Parse(txtCredits.Text));
                cmd.Parameters.AddWithValue("@level", txtLevel.Text);
                cmd.Parameters.AddWithValue("@type", txtCourseType.Text);
                cmd.Parameters.AddWithValue("@active", chkIsActive.Checked);
                cmd.Parameters.AddWithValue("@specId", cmbSpecialization.SelectedValue);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Course updated successfully");
            LoadCourses();
            ClearCourseFields();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseId.Text))
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this course?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Courses WHERE CourseID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtCourseId.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Course deleted successfully");
            LoadCourses();
            ClearCourseFields();
        }

        private bool ValidateCourseForm()
        {
            bool valid = true;

            valid &= IsRequired(txtCourseId, "Course ID is required");
            valid &= IsInt(txtCourseId, "Course ID must be a number");

            valid &= IsRequired(txtCourseCode, "Course Code is required");

            valid &= IsInRange(txtCredits, 1, 6, "Credits must be between 1 and 6");
            valid &= IsInRange(txtLevel, 100, 600, "Level must be between 100 and 600");

            valid &= IsLettersOnly(txtCourseName, "Course Name must contain letters only");
            valid &= IsLettersOnly(txtCourseType, "Course Type must contain letters only");


            if (cmbSpecialization.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbSpecialization, "Please select a specialization");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(cmbSpecialization, "");
            }

            return valid;
        }


        private void ClearCourseFields()
        {
            txtCourseId.Clear();
            txtCourseCode.Clear();
            txtCourseName.Clear();
            txtCredits.Clear();
            txtLevel.Clear();
            txtCourseType.Clear();
            chkIsActive.Checked = true;
            cmbSpecialization.SelectedIndex = -1;
        }

        private bool IsRequired(TextBox tb, string message)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                errorProvider1.SetError(tb, message);
                return false;
            }
            errorProvider1.SetError(tb, "");
            return true;
        }

        private bool IsInt(TextBox tb, string message)
        {
            if (!int.TryParse(tb.Text, out _))
            {
                errorProvider1.SetError(tb, message);
                return false;
            }
            errorProvider1.SetError(tb, "");
            return true;
        }

        private bool IsInRange(TextBox tb, int min, int max, string message)
        {
            if (!int.TryParse(tb.Text, out int value) || value < min || value > max)
            {
                errorProvider1.SetError(tb, message);
                return false;
            }
            errorProvider1.SetError(tb, "");
            return true;
        }

        private bool IsLettersOnly(TextBox tb, string message)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                errorProvider1.SetError(tb, message);
                return false;
            }

            foreach (char c in tb.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    errorProvider1.SetError(tb, message);
                    return false;
                }
            }

            errorProvider1.SetError(tb, "");
            return true;
        }



        private void panelCourses_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
