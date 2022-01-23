using Aveva.Employee.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Aveva.Employee.Api.Configurations
{
    public static class ContextDbConfiguration
    {
        public static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("EmployeeDbContext")));

            return services;
        }
    }
}
