using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForm.DAL.Models
{
    public enum JobRole
    {
        Manager,
        Developer,
        Designer
    }
    public enum Gender
    {
        Male,
        Female
    }

    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public JobRole JobRole { get; set; }
        public Gender Gender { get; set; }
        public bool FirstAppointment { get; set; }
        public DateTime StartDate { get; set; }

        [MaxLength(500)]
        public string Notes { get; set; }
    }
}
