using Aveva.Employee.Common;
using Aveva.Employee.Common.Auth;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;

namespace Aveva.Employee.Api.Configurations
{
    public static class AuthorizationConfiguration
    {
        public static IServiceCollection ConfigureAuthentication(this IServiceCollection services, AuthSettings authSettings)
        {
            string issuer = authSettings.JwtIssuer;

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false
                };
                options.Authority = issuer;
            });

            services.AddAuthorization(options =>
            {
                foreach (var scope in Scopes.RetrieveAll())
                {
                    options.AddPolicy(scope, policy => policy.Requirements.Add(new HasScopeRequirement(scope, issuer)));
                }
            });

            services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();

            return services;
        }
    }
}
