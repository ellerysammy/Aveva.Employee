using Microsoft.AspNetCore.Authorization;

namespace Aveva.Employee.Common.Auth
{
    public class HasScopeRequirement : IAuthorizationRequirement
    {
        public string Issuer { get; }
        public string Scope { get; }

        public HasScopeRequirement(string scope, string issuer)
        {
            this.Scope = scope ?? throw new ArgumentNullException(nameof(scope));
            this.Issuer = issuer ?? throw new ArgumentNullException(nameof(issuer));
        }
    }
}
