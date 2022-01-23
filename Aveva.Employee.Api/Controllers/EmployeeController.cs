using AutoMapper;
using Aveva.Employee.Common.RequestModels;
using Aveva.Employee.Services.Interfaces;
using AvevaModels = Aveva.Employee.DataContracts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Aveva.Employee.Common.Auth;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Aveva.Employee.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService;
        private readonly IMapper _autoMapper;

        public EmployeeController(IEmployeeService employeeService, IMapper autoMapper)
        {
            _employeeService = employeeService;
            _autoMapper = autoMapper;
        }

        [HttpGet]
        [Authorize(Scopes.DoitAll)]
        public async Task<IActionResult> Get([FromRoute] EmployeeRequestGet request)
        {
            try
            {
                var result = await _employeeService.GetEmployes(request.FirstName, request.LastName, request.Email);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("GetAll")]
        [Authorize(Scopes.DoitAll)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _employeeService.GetEmployes();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Authorize(Scopes.DoitAll)]
        public async Task<IActionResult> Post([FromBody] EmployeeRequestCreate request)
        {
            try
            {
                var mapEmployee = _autoMapper.Map<AvevaModels.Employee>(request);
                var result = await _employeeService.CreateEmployee(mapEmployee);
                return CreatedAtAction(nameof(Get), new { Id = result.Id }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        [Authorize(Scopes.DoitAll)]
        public async Task<IActionResult> Put(int id, [FromBody] EmployeeRequestUpdate request)
        {
            try
            {
                var mapEmployee = _autoMapper.Map<AvevaModels.Employee>(request);
                mapEmployee.Id = id;
                var result = await _employeeService.UpdateEmployee(mapEmployee);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
