using EmployeeForm.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForm.BLL.IServices
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        Task<Employee?> GetEmployeeAsync(int id);
        Task<GeneralStatus> AddEmployeeAsync(Employee employee);
    }
}
