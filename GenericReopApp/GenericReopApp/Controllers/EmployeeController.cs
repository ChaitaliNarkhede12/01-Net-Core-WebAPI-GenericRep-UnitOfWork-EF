using Application.Interfaces;
using DataaAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GenericReopApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeApp _employeeService;
        public EmployeeController(IEmployeeApp employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet("api/Employee/GetEmployeeList")]
        public async Task<IActionResult> Get()
        {
            var result = await _employeeService.GetEmployeeList();
            return Ok(result);
        }

        [HttpGet("api/Employee/GetEmployeeById/{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var result = await _employeeService.GetEmployeeById(x => x.EmpId == id);
            return Ok(result);
        }

        [HttpPost("api/Employee/SaveEmployee")]
        public async Task<IActionResult> SaveEmployee(Employee employee)
        {
            var result = await _employeeService.AddEmployee(employee);
           return Ok(result);
        }

        [HttpPost("api/Employee/UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(Employee employee)
        {
            var result = await _employeeService.UpdateEmployee(employee);
            return Ok(result);
        }

        [HttpPost("api/Employee/DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var result = await _employeeService.DeleteEmployee(id);
            return Ok(result);
        }
    }
}
