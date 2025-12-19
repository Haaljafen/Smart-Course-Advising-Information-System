using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace S6G2
{
    public static class DatabaseHelper
    {
        public static void InsertTestData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SCAIS_DB"].ConnectionString;
            string sql = "INSERT INTO YourTable (Column1) VALUES ('TestValue')";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
