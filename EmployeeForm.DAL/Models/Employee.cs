using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="The Employee Field is Required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="The Name should be between 3 and 50 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Job Role Field is Required")]
        public JobRole JobRole { get; set; }
      
        public Gender Gender { get; set; }

        public bool FirstAppointment { get; set; }
        [Required(ErrorMessage = "The  Date Field is Required")]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [MaxLength(500,ErrorMessage = "The Notes Field should have a maximum of 500 characters ")]
        public string? Notes { get; set; }


    }
}
