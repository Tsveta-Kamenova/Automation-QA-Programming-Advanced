using System.Text.RegularExpressions;

namespace _12.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string pattern = @"\+359([\ \-])2\1\d{3}\1\d{4}\b";

            MatchCollection matches = Regex.Matches(inputText, pattern);
            
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}