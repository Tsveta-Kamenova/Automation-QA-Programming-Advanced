using System.Text;

namespace _02.RepeatStrings
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    string[] words = Console.ReadLine().Split();

        //    StringBuilder result = new();

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        string currentword = words[i];

        //        for (int j = 0; j < currentword.Length; j++)
        //        {
        //            result.Append(currentword);
        //        }
        //    }
        //    Console.WriteLine(result);
        //}


        //static void Main(string[] args)
        //{
        //    string[] words = Console.ReadLine().Split();

        //    string result = "";

        //    foreach (string word in words)
        //    {
        //        int repeatTimes = word.Length;

        //        for (int i = 0; i < repeatTimes; i++)
        //        {
        //            result += word;
        //        }
        //    }
        //    Console.WriteLine(result);
        //}

        static void Main(string[] args)
        {
            string words = string.Concat(Console.ReadLine().Split(" ").Select(x => string.Concat(Enumerable.Repeat(x, x.Length))));

            Console.WriteLine(words);
        }


    }
}
