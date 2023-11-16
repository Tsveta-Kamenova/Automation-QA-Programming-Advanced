namespace _22.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine()
                            .Split(" ")
                            .Select(s => s.ToLower())
                            .ToArray();

            Dictionary<string, int> OddOccurancesOfAWord = new();

            foreach (string word in words)
            {
                if (OddOccurancesOfAWord.ContainsKey(word))
                {
                    OddOccurancesOfAWord[word] += 1;
                }
                else
                {
                    OddOccurancesOfAWord[word] = 1;
                }
            }

            string[] result = OddOccurancesOfAWord
                .Where(x => x.Value % 2 != 0)
                .Select(x => x.Key)
                .ToArray();
            
            Console.WriteLine(string.Join(" ",result));



            //    string[] words = Console.ReadLine().Split(" ");

            //    Dictionary<string, int> OddOccurancesOfAWord = new();

            //    foreach (string word in words)
            //    {
            //        string lowerWord = word.ToLower();

            //        if (OddOccurancesOfAWord.ContainsKey(lowerWord))
            //        {
            //            OddOccurancesOfAWord[lowerWord] += 1;
            //        }
            //        else
            //        {
            //            OddOccurancesOfAWord[lowerWord] = 1;
            //        }
            //    }

            //    foreach (KeyValuePair<string, int> pair in OddOccurancesOfAWord)
            //    {
            //        int countOccurances = pair.Value;

            //        if (countOccurances % 2 != 0)
            //        {
            //            Console.Write(pair.Key + " ");
            //        }
            //    }
        }
    }
}