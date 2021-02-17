using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _5BTelemedicineApp.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public virtual Patients Patients { get; set; }
       
        public virtual Provider Provider { get; set; }

        public Appointment()
        {

        }
    }
}
