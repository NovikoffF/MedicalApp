﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp
{
    class Attendance
    {
        public int Id { get; set; }
        public string ClinicRemarks { get; set; }
        public string  Diagnosis {get; set;}
        public string SecondDiagnosis { get; set; }
        public string ThirdDiagnosis { get; set; }
        public string Therapy { get; set; }
        public DateTime Date { get; set; }

        public Patient Patient { get; set; }


    }
}
