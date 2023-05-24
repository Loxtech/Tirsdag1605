﻿using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirsdag1605
{
    public class Car
    {
        public int Id { get; set; }
        public string? Color { get; set; }
        public int Age { get; set; }
        public string? Name { get; set; }
        public string? Model { get; set; }
        public string? Maker { get; set; }

        public static string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=h1; Trusted_Connection=true; TrustServerCertificate=True";

        public void create()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $"insert into car values('{Color}','','{Model}','{Maker}',{Age})";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        public void delete(int id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $"DELETE FROM car WHERE id={id}";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
        }

        public static void ReadAll()
        {
            SqlConnection con = new SqlConnection(connectionString);

            string query = $"SELECT * FROM car";
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
            string query = $"SELECT * FROM car WHERE id={id}";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            Console.WriteLine($"{rdr[0]}, {rdr[1]}, {rdr[3]}, {rdr[4]}, {rdr[5]}");
            rdr.Close();
            cmd.ExecuteNonQuery();
        }

        
    }
}
