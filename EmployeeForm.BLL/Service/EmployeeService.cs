using EmployeeForm.BLL.IServices;
using EmployeeForm.DAL.Data;
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


    }
}
