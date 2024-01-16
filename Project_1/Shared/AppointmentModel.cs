using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Shared
{
    public class AppointmentModel
    {
       
        public int Id { get; set; } // Key ID
        public string Doctor { get; set; }
        public DateTime Date { get; set; }
        public string AdditionalNotes { get; set; }
    }
}
