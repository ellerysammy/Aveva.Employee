namespace Aveva.Employee.Common.Auth
{
    public static class Scopes
    {
        private static readonly IList<string> all = All();
        public const string DoitAll = "read:client_grants";

        private static List<string> All()
        {
            IEnumerable<string> scopes = from f in typeof(Scopes).GetFields()
                                         where f.IsPublic
                                         select $"{f.GetValue(null)}";
            return scopes.ToList();
        }

        public static IList<string> RetrieveAll()
        {
            return all;
        }
    }
}
