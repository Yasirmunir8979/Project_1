using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Shared
{
    public class DiagnosticModel
    {
      
        public int Id { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string FamilyHistory { get; set; }
        public string IncreasedThirst { get; set; }
        public string IncreasedHunger { get; set; }
        public string WeightLoss { get; set; }
        public string Fatigue { get; set; }
        public string UrinationFrequency { get; set; }
        public string BlurredVision { get; set; }
        public string Symptoms { get; set; }
        public string Diagnosis { get; set; }
    }
}
