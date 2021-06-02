using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp
{
    class Appointment
    {
        public readonly int Id;
        public DateTime StartDateTime { get; set; }
        public string Detail { get; set; }

        public bool Status { get; set; }
        public Doctor Doctor { get; set; }

        
    }
}
