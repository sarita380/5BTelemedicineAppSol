using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _5BTelemedicineApp.Models
{
    public class Patients
    {
        [Key]
        public int Id { get; set; }
       
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string DOB { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        
        public Patients()
        {

        }

    }
}
