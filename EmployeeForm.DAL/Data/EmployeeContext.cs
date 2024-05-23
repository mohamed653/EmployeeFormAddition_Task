using EmployeeForm.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForm.DAL.Data
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext()
        {
        }
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=EmployeeForm;Integrated Security=true;TrustServerCertificate=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Seed data
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Mohamed", Gender = Gender.Male, StartDate = DateTime.Now, FirstAppointment = true, JobRole = JobRole.Developer, Notes = "some additional notes" },
                new Employee { Id = 2, Name = "Hamed",Gender=Gender.Male,StartDate=DateTime.Now,FirstAppointment=true,JobRole=JobRole.Developer,Notes="some additional notes" }
            );
        }

    }
}
