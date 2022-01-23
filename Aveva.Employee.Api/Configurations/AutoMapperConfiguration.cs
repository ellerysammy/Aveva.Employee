using System.Reflection;

namespace Aveva.Employee.Api.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static IServiceCollection ConfigureMappings(this IServiceCollection services)
        {
            if (services != null)
            {
                services.AddAutoMapper(Assembly.GetExecutingAssembly());
            }

            return services;
        }
    }
}
