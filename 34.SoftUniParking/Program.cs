namespace _34.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> employeePlateNumber = new();

            int employees = int.Parse(Console.ReadLine());

            for (int i = 0; i < employees; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string command = input[0];
                string employeeName = input[1];


                if (command == "register")
                {
                    string plateNumber = input[2];

                    if (employeePlateNumber.ContainsKey(employeeName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {employeePlateNumber[employeeName]}");
                    }
                    else
                    {
                        employeePlateNumber[employeeName] = plateNumber;
                        Console.WriteLine($"{employeeName} registered {plateNumber} successfully");
                    }
                }
                else
                {
                    if (employeePlateNumber.ContainsKey(employeeName))
                    {
                        Console.WriteLine($"{employeeName} unregistered successfully");
                    }
                    else 
                    {
                        Console.WriteLine($"ERROR: user {employeeName} not found");
                    }
                }
            }

            foreach (var currentEmployee in employeePlateNumber)
            {
                Console.WriteLine(currentEmployee.Key + " => " + currentEmployee.Value);
            }
        }
    }
}