using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirsdag1605
{
    public class Database
    {
        //(localdb)\MSSQLLocalDB
        public string connectionString { get; set; } = @"Server=(localdb)\MSSQLLocalDB;Database=h1; Trusted_Connection=true; TrustServerCertificate=True";

        // insert into tablename (columnnames) values();
        // insert into tablename values();
        // a programing language consists of 4 subjects:
        // 1) Methodes
        // 2) Variables
        // 3) Types
        // 4) A soul

        public void createHardcoded()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "insert into animal values('green','','Jim','Jenson',40)";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="justSoItWorks"></param>
        
    }
}
