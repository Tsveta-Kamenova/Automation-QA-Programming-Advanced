namespace _24.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();
            string[] result = words.Where(X => X.Length % 2 == 0).ToArray();

            foreach (string word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}