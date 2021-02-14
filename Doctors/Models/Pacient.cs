using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Doctors.Models
{
    public class Pacient
    {
        public Pacient(int pacientId, string name, string surname, int doctorId)
        {
            PacientId = pacientId;
            Name = name;
            Surname = surname;
            DoctorId = doctorId;
        }

        public int PacientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DoctorId { get; set; }
    }
}