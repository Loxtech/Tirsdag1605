using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirsdag1605
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Color { get; set; }
        public int Age { get; set; }
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public static string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=h1; Trusted_Connection=true; TrustServerCertificate=True";

        public void create()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $"insert into animal values('{Color}','','{FirstName}','{LastName}',{Age})";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        public void delete(int id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $"DELETE FROM animal WHERE id={id}";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        public static void ReadAll()
        {
            SqlConnection con = new SqlConnection(connectionString);

            string query = $"SELECT * FROM animal";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr[0]}, {rdr[1]}, {rdr[3]}, {rdr[4]}, {rdr[5]}");
                }
                rdr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occurred: " + e);
            }
            finally
            {
                con.Close();
            }
        }

        public static void Read(int id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $"SELECT * FROM animal WHERE id={id}";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            Console.WriteLine($"{rdr[0]}, {rdr[1]}, {rdr[3]}, {rdr[4]}, {rdr[5]}");
            rdr.Close();
            cmd.ExecuteNonQuery();
        }

        public static void NameJumble(int id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $"SELECT * FROM animal WHERE id={id}";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string firstName = rdr[3].ToString();
                string lastName = rdr[4].ToString();
                char[] firstArr = firstName.ToCharArray();
                char[] lastArr = lastName.ToCharArray();

                Console.WriteLine(firstArr[0] + firstArr[1] + firstArr[2] + lastArr[0] + lastArr[1] + lastArr[2] + firstArr[3] + firstArr[4] + firstArr[5] + lastArr[3] + lastArr[4] + lastArr[5]);
                Console.WriteLine(firstName + lastName);
            }
            rdr.Close();
            cmd.ExecuteNonQuery();
        }


    }
}
