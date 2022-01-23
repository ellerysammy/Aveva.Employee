using AvevaModels = Aveva.Employee.DataContracts.Models;

namespace Aveva.Employee.Services.Interfaces
{
    public interface IEmployeeService
    {
        public Task<List<AvevaModels.Employee>> GetEmployes(string? firstName, string? lastName, string? email);

        public Task<IEnumerable<AvevaModels.Employee>> GetEmployes();

        public Task<AvevaModels.Employee> CreateEmployee(AvevaModels.Employee employee);
        public Task<AvevaModels.Employee> UpdateEmployee(AvevaModels.Employee employee);
    }
}
