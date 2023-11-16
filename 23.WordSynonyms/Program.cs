namespace _23.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPairs = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonymsDictionary = new();

            for (int i = 0; i < numberOfPairs; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (synonymsDictionary.ContainsKey(word))
                {
                    synonymsDictionary[word].Add(synonym);
                }
                else
                {
                    synonymsDictionary.Add(word, new List<string>() { synonym });
                }
            }

            foreach (KeyValuePair<string, List<string>> pair in synonymsDictionary)
            {
                Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
            }
        }
    }
}