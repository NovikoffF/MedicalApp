using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp
{
    class Patient : User
    {

        public DateTime BirthDate { get; set; }
        public Gender Sex { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public City Cities { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Attendance> Attendances { get; set; }

        public int Age
        {
            get
            {
                var now = DateTime.Today;
                var age = now.Year - BirthDate.Year;
                if (BirthDate > now.AddYears(-age)) age--;
                return age;
            }
        }



        public Patient(string id, string pass, string rname, string email, string name, string surname)
             : base(id, pass, rname, email, name, surname)
        {


        }
        public void RegistrationOnAppointment(User user, Appointment app)
        {

        }

        public void GetMessageAppointment()
        {

        }
        public void AppointmentTable()
        {

        }

       
    }
}

