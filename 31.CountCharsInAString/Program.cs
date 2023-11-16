namespace _31.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();

            Dictionary<char, int> letterOccurances= new();

            foreach(char letter in stringInput)
            {
                if (letter != ' ')
                {
                    if (!letterOccurances.ContainsKey(letter)) { letterOccurances[letter] = 1; }
                    else { letterOccurances[letter]++; };
                }
            }
            foreach (KeyValuePair<char, int> pair in letterOccurances)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

        }
    }
}