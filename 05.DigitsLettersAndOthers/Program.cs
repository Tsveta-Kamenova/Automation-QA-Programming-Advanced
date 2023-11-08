using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

using System.Text.RegularExpressions;
using System.Text;

namespace _05.DigitsLettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            StringBuilder digits = new();
            StringBuilder letters = new ();
            StringBuilder otherSymbols = new ();

            foreach (char symbol in inputString)
            {
                if (char.IsDigit(symbol))
                {
                    digits.Append(symbol);
                }
                else if (char.IsLetter(symbol))
                {
                    letters.Append(symbol);
                }
                else
                    otherSymbols.Append(symbol);
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherSymbols);
        }
    }
}