using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S6G2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserid.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show(" Please enter both Username and Password!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = Properties.Settings.Default.SCIAS_DBConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE UserID=@userid AND PasswordHash = @password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@userid", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // COUNT(*) always returns a number (0 or more)
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // ✅ FIX:
                        // Access is granted ONLY if count > 0
                        if (count > 0)
                        {
                            int adviserId = 1;
                            // ⚠️ NOTE:
                            // We are NOT retrieving the real UserID yet.
                            // Login logic is temporary for testing purposes.

                            MessageBox.Show(
                                "Access Granted",
                                "Login Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            // 🔽 CURRENT BEHAVIOR
                            // Any valid user is sent to the Adviser page
                            new Adviser(adviserId).Show();
                            this.Hide();

                            // =====================================================
                            // 🔴 FUTURE ROLE-BASED CONDITION (NOT IMPLEMENTED YET)
                            // =====================================================
                            // After modifying the SQL query to return UserID + Role:
                            //
                            // if (role == "Adviser")
                            // {
                            //     new Adviser(userId).Show();
                            // }
                            // else if (role == "Student")
                            // {
                            //     new StudentForm(userId).Show();
                            // }
                            // else if (role == "Admin")
                            // {
                            //     new AdminForm().Show();
                            // }
                            //
                            // This will distribute users to the correct page
                            // based on their role in the Users table.
                            // =====================================================
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUserid.Clear();
                            txtPassword.Clear();
                            txtUserid.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
