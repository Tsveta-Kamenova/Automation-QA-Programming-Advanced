namespace _62.EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int ReadNumbers(int start, int end)
            {
                int num = int.Parse(Console.ReadLine());

                if (num <= start || num >= end)
                {
                    throw new ArgumentException();
                }
                return num;
            }

            List<int> numbers = new List<int>();
            int prevNum = 1;

            while (numbers.Count < 10)
            {
                int number = ReadNumbers(prevNum, 100);
                numbers.Add(number);
                prevNum = number;
            }

            Console.WriteLine(string.Join(",", numbers));
        }
    }
}