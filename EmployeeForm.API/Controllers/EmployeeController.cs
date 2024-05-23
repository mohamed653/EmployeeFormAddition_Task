using EmployeeForm.BLL;
using EmployeeForm.BLL.IServices;
using EmployeeForm.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeForm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        /// <summary>
        /// this method is used to get all employees
        /// </summary>
        /// <returns>List of employees</returns>
        [HttpGet]
        public async Task <IActionResult> GetAllEmployees()
        {
            var employees = await _employeeService.GetEmployeesAsync();

            return Ok(employees);
        }


        /// <summary>
        /// this method is used to get employee by id
        /// </summary>
        [HttpGet("{employeeId}")]
        public async Task<IActionResult> GetEmployeeById(int employeeId)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(employeeId);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        /// <summary>
        /// Create new employee ,(Job types)==> (0:Manger,1:Developer,2:Designer), (Gender)==>(0:Male,1:Female)
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var returnStatus = await _employeeService.AddEmployeeAsync(employee);

                if (returnStatus == GeneralStatus.Success)
                {
                    return CreatedAtAction(nameof(GetEmployeeById), new { employeeId = employee.Id }, employee);
                }
                else if (returnStatus == GeneralStatus.ExistBefore)
                {
                    return Conflict();
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return BadRequest(ModelState); 
        }

    }
}
