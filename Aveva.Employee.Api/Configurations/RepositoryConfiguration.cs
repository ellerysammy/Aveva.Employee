using Aveva.Employee.Data.Repositories;
using Aveva.Employee.Data.Repositories.Interfaces;
using Aveva.Employee.Services;
using Aveva.Employee.Services.Interfaces;

namespace Aveva.Employee.Api.Configurations
{
    public static class RepositoryConfiguration
    {
        public static IServiceCollection ConfigureRepos(this IServiceCollection services)
        {
            if (services != null)
            {
                services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            }

            return services;
        }
    }
}
