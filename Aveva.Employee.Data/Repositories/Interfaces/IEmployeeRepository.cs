using AvevaModels = Aveva.Employee.DataContracts.Models;

namespace Aveva.Employee.Data.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task<List<AvevaModels.Employee>> Get(string? firstName, string? lastName, string? email);

        public Task<IEnumerable<AvevaModels.Employee>> GetAll();

        public Task<int> Create(AvevaModels.Employee newEmployee);

        public Task<int> Update(AvevaModels.Employee employeeToUpdate);
    }
}
