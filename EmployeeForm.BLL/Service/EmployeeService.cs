using EmployeeForm.BLL.IServices;
using EmployeeForm.DAL.Data;
using EmployeeForm.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForm.BLL.Service
{
    public class EmployeeService:IEmployeeService
    {
        private readonly EmployeeContext _context;

        public EmployeeService(EmployeeContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetEmployeeByIdAsync(int id)
        {

            if (id <= 0)
                return null;
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<GeneralStatus> AddEmployeeAsync(Employee employee)
        {
            if (employee == null)
                return GeneralStatus.NotValid;
            try
            {
                var _employee = await GetEmployeeByIdAsync(employee.Id);
                if (_employee != null)
                    return GeneralStatus.ExistBefore;

                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();
                return GeneralStatus.Success;
            }
            catch (Exception)
            {
                return GeneralStatus.Fail;
            }
        }

    }
}
