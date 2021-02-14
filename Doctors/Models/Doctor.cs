using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Doctors.Models
{
    public class Doctor
    {
        public Doctor(int doctorId, string name, string surname, string speciality)
        {
            DoctorId = doctorId;
            Name = name;
            Surname = surname;
            Speciality = speciality;
        }

        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Speciality { get; set; }
    }
}