using EmployeeForm.BLL;
using EmployeeForm.BLL.IServices;
using EmployeeForm.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeForm.Host.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var employees = await _employeeService.GetEmployeesAsync();

            return View(employees);
        }

        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var employees = await _employeeService.GetEmployeesAsync();
            return PartialView("_EmployeeList",employees);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            var _employees = await _employeeService.GetEmployeesAsync();
            if (ModelState.IsValid)
            {

                var returnStatus = await _employeeService.AddEmployeeAsync(employee);

                if (returnStatus == GeneralStatus.Success)
                {
                    return Json(new { success = true, message = "Employee added successfully!" });
                }
                else if (returnStatus == GeneralStatus.ExistBefore)
                {
                    return Json(new { success = false, message = "Employee with this Id already exists" });
                }
                else
                {
                    return Json(new { success = false, message = "Failed to add employee" });
                }
            }
            return Json(new { success = false, message = "Employee data is invalid" });
        }
    }
}
