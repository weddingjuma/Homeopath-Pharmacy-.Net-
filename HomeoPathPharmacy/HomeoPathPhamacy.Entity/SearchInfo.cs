﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeoPathPhamacy.Entity
{
    public class SearchInfo
    {
        private int patientId;
        private string patientName;
        private string medicineName;
        private int amount;
        private string symptom;
        public string Sys_date { get; set; }
        private int paid;
        private int have_to_paid;
        public int PatientId { get { return patientId; } set { patientId = value; } }
        public string PatientName { get { return patientName; } set { patientName = value; } }
        public string MedicineName { get { return medicineName; } set { medicineName = value; } }
        public int Amount { get { return amount; } set { amount = value; } }
        public int Paid { get { return paid; } set { paid = value; } }
        public int Have_To_Paid { get { return have_to_paid; } set { have_to_paid = value; } }
        public string Symptom { get { return symptom; } set { symptom = value; } }
        //public DateTime Sys_Date { get { return sys_Date; } set { sys_Date = value; } }
    }
}
