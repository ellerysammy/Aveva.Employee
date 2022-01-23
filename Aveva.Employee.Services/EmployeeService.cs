using AutoMapper;
using Aveva.Employee.Data.Repositories.Interfaces;
using Aveva.Employee.Services.Interfaces;
using AvevaModels = Aveva.Employee.DataContracts.Models;

namespace Aveva.Employee.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<AvevaModels.Employee> CreateEmployee(AvevaModels.Employee employee)
        {
            _ = await _employeeRepository.Create(employee);
            return employee;
        }

        public async Task<IEnumerable<AvevaModels.Employee>> GetEmployes()
        {
            return await _employeeRepository.GetAll();
        }

        public async Task<List<AvevaModels.Employee>> GetEmployes(string? firstName, string? lastName, string? email)
        {
            return await _employeeRepository.Get(firstName, lastName, email);
        }

        public async Task<AvevaModels.Employee> UpdateEmployee(AvevaModels.Employee employee)
        {
            _ = await _employeeRepository.Update(employee);
            return employee;
        }
    }
}
