using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_App.DATABASE.Models
{
    public class ConnectSQL
    {
        public static string GetConnectionString()
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder()
            {
                InitialCatalog = "Library_Management",
                DataSource = @"KD_PC",
                IntegratedSecurity = true,
                MultipleActiveResultSets = true,
                ConnectTimeout = 0,
                MaxPoolSize = 500,
                TrustServerCertificate = true
            };
            return stringBuilder.ConnectionString;
        }
        public static DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            string conn_string = GetConnectionString();
            SqlConnection sqlConnect = new SqlConnection(conn_string);
            sqlConnect.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlConnect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static bool ExecuteNonQuery(string sql)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
    }
}
