using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Doctors.Models
{
    public class DoctorsRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server=localhost;Port=3306;Database=doctors;Uid=root;password=mysql;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal List<Doctor> Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from doctors";

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();
                Doctor d = null;
                List<Doctor> doctors = new List<Doctor>();

                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + res.GetString(1) + res.GetString(2) + res.GetString(3));
                    d = new Doctor(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3));
                    doctors.Add(d);
                }
                con.Close();
                return doctors;
            } catch(MySqlException e)
            {
                Debug.WriteLine(e);
                return null;
            }
            
        }
    }
}