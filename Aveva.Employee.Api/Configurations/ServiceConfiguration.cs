using Aveva.Employee.Services;
using Aveva.Employee.Services.Interfaces;

namespace Aveva.Employee.Api.Configurations
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            if (services != null)
            {
                services.AddTransient<IEmployeeService, EmployeeService>();
            }
            return services;
        }
    }
}
