using System.Data.SqlClient;
using System.IO;

public static class Db
{
    public static SqlConnection GetConn()
    {
        string dbPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "SCAIS_DB2.mdf");

        string cs = $@"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename={dbPath};
Integrated Security=True;
Connect Timeout=30;";

        return new SqlConnection(cs);
    }
}
