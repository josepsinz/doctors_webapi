using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Doctors.Models
{
    public class PacientsRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server=localhost;Port=3306;Database=doctors;Uid=root;password=mysql;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal List<Pacient> RetrieveByDoctorId(int id)
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from pacients where doctorid = @id" ;
            command.Parameters.AddWithValue("@id", id);
            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();
                Pacient p = null;
                List<Pacient> pacients = new List<Pacient>();

                while (res.Read())
                {
                    Debug.WriteLine("Retrivied: " + res.GetInt32(0) + res.GetString(1) + res.GetString(2) + res.GetInt32(3));
                    p = new Pacient(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetInt32(3));
                    pacients.Add(p);
                }
                con.Close();
                return pacients;
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e);
                return null;
            }

        }
    }
}