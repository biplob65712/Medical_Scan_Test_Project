using MedicalScan.MODELS.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MedicalScan.DATABASE
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Specialty> SpecialtyTB { get; set; }
        public DbSet<Doctor> DoctorTB { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectionString = @"Server=DESKTOP-CR30BFH\SQLEXPRESS; Database=Medical_Scan_Project_DB; Trusted_Connection=True; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);


        }
    }
}
