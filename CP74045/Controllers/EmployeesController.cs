using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CP74045.Data.Services;
using CP74045.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CP74045.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public EmployeesService _employeesService;
        public EmployeesController(EmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        [HttpPost("add-employee")]
        public IActionResult AddClient([FromBody]EmployeeVM client)
        {
            _employeesService.AddEmployee(client);
            return Ok();
        }

        //httpget

        [HttpGet("get-all-employee")]
        public IActionResult GetAllEmployees()
        {
            var allemployees = _employeesService.GetAllEmployees();
            return Ok(allemployees);
        }

        [HttpGet("get-employee-by-id/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeesService.GetEmployeeById(id);
            return Ok(employee);
        }

        [HttpPut("update-employee-by-id/{id}")]
        public IActionResult UpdateEmployeeById(int id, [FromBody]EmployeeVM employee)
        {
            var updatedEmployee = _employeesService.UpdateEmployeeById(id, employee);
            return Ok(updatedEmployee);
        }

        [HttpDelete("delete-employee-by-id/{id}")]
        public IActionResult DeleteEmployeeById(int id)
        {
            _employeesService.DeleteEmployeeById(id);
            return Ok();
        }
    }
}