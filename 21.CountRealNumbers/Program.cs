namespace _21.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            SortedDictionary<int, int> numbersFrequency = new();

            foreach (int number in numbers)
            {
                if (numbersFrequency.ContainsKey(number)) numbersFrequency[number]++;
                else
                {
                    numbersFrequency[number] = 1;
                }
            }
            foreach (KeyValuePair<int, int> pair in numbersFrequency)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }


        }
    }
}