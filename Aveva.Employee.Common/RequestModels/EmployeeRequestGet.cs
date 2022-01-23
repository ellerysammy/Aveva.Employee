using Microsoft.AspNetCore.Mvc;

namespace Aveva.Employee.Common.RequestModels
{
    public class EmployeeRequestGet
    {      
        [FromQuery(Name = "first_name")]
        public string? FirstName { get; set; }
        
        [FromQuery(Name = "last_name")] 
        public string? LastName { get; set; }
        
        [FromQuery(Name = "email")] 
        public string? Email { get; set; }
    }
}