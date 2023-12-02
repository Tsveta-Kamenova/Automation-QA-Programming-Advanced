namespace _63.SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().Split().ToList();
            
            foreach (string number in strings)
            {

            }
            int sum = strings.Sum();

            Console.WriteLine($"The total sum of all integers is: {sum}");

        }
    }
}