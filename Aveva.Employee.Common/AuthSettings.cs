using System.ComponentModel.DataAnnotations;

namespace Aveva.Employee.Common
{
    public  class AuthSettings
    {
        [Required]
        [RegularExpression(@"^https{1}:\/\/", ErrorMessage = "JWT Issuer URL must be secured by https protocol")]
        public string JwtIssuer { get; set; }
    }
}
