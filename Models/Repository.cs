namespace HRApplicationnew.Models
{
    public class Repository
    {
        private static List<Employees> employeesList = new List<Employees>();

        public static IEnumerable<Employees> GetEmployees()
        {
            return employeesList;
        }

        public static void AddEmployee(Employees emp)
        {
            employeesList.Add(emp);
        }

    }
}
