namespace Aveva.Employee.Common.RequestModels
{
    [Serializable]
    public class EmployeeRequestUpdate
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public bool Active { get; set; }
    }
}
