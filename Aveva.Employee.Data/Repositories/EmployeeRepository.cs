using Aveva.Employee.Data.Context;
using Aveva.Employee.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using AvevaModels = Aveva.Employee.DataContracts.Models;

namespace Aveva.Employee.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
		private readonly EmployeeDbContext _context;

		public EmployeeRepository(EmployeeDbContext context) 
		{
			_context = context;
		}
		public async Task<List<DataContracts.Models.Employee>> Get(string? firstName, string? lastName, string? email)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.Employee.Where(emp => (emp.Active
														&& (emp.FirstName.StartsWith(firstName) || string.IsNullOrEmpty(firstName))
														&& (emp.LastName.StartsWith(lastName) || string.IsNullOrEmpty(lastName))
                                                        && (emp.Email == email || string.IsNullOrEmpty(email)))).ToListAsync();
#pragma warning restore CS8603 // Possible null reference return.
        }

		async Task<IEnumerable<AvevaModels.Employee>> IEmployeeRepository.GetAll()
		{
#pragma warning disable CS8603 // Possible null reference return.
			return await _context.Employee.ToListAsync();
#pragma warning restore CS8603 // Possible null reference return.
		}

		public async Task<int> Create(AvevaModels.Employee newEmployee)
		{
			await _context.Employee.AddAsync(newEmployee);
			return await _context.SaveChangesAsync();
		}

		public async Task<int> Update(AvevaModels.Employee employeeToUpdate)
		{
			_context.Employee.Update(employeeToUpdate);
			return await _context.SaveChangesAsync();
		}
    }
}
