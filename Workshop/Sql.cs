using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

    
namespace Workshop
{
    class Sql
    {
        private static string ConnectionStreng = "Data Source=TEC-5350-LA0116;Initial Catalog=sqleksempler; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static void insert(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStreng))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
