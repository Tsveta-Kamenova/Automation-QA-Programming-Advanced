using System.Runtime.CompilerServices;

namespace _36.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyUsers = new();

            string input = Console.ReadLine() ?? "a";

            while (input != "End")
            {
                string[] inputArray = input.Split(" -> ");

                string company = inputArray[0];
                string employeeId = inputArray[1];

                if (!companyUsers.ContainsKey(company))
                {
                    companyUsers.Add(company, new());
                }

                if (!companyUsers[company].Contains(employeeId))
                {
                    companyUsers[company].Add(employeeId);
                }
                
                input = Console.ReadLine();
            }
            foreach (var currentCompany in companyUsers)
            {
                Console.WriteLine(currentCompany.Key);

                foreach (string currentEmployeeId in currentCompany.Value)
                {
                    Console.WriteLine($"-- {currentEmployeeId}");
                }
            }

        }
    }
}