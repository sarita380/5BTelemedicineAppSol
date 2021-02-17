using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using _5BTelemedicineApp.Models;

namespace _5BTelemedicineApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<_5BTelemedicineApp.Models.Provider> Provider { get; set; }
        public DbSet<_5BTelemedicineApp.Models.Patients> Patients { get; set; }
        public DbSet<_5BTelemedicineApp.Models.Appointment> Appointment { get; set; }
        public DbSet<_5BTelemedicineApp.Models.MyChartBook> MyChartBook { get; set; }
    }
}
