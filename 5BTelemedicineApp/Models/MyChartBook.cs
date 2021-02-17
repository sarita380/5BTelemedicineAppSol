using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _5BTelemedicineApp.Models
{
    public class MyChartBook
    {
        [Key]
        public int Id { get; set; }
        public virtual Patients Patients { get; set; }
        public virtual Provider Provider { get; set; }
        public string Message { get; set; }
        public string Diagnostic { get; set; }
        public virtual Appointment Appointment { get; set; }
        public MyChartBook()
        {

        }
    }
}
