using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp
{
    class Doctor: User
    {
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }
        public string Graduate { get; set; }
        public int RoomNumber { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

        public Doctor(string id, string pass, string rname, string email, string name, string surname):
            base(id, pass, rname, email, name,surname)
        {
            
        }

        public void ShowPatientList()
        {

        }

        public void MakeAppointment()
        {

        }
        public void RemoveAppointment()
        {

        }
    }
}
