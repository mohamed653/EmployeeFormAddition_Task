using EmployeeForm.BLL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeForm.Host.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
