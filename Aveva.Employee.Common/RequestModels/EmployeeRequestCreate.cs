namespace Aveva.Employee.Common.RequestModels
{
    [Serializable]
    public class EmployeeRequestCreate
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
