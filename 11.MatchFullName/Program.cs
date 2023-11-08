using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;


namespace _11.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(inputText);

            var fullNames = matches.Cast<Match>().Select(match => match.Value).ToList();

            Console.WriteLine(string.Join(" ", fullNames));
        }
    }
}