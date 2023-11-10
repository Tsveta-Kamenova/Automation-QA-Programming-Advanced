using System.Linq;

namespace _01.ReverseStrings;
class Program
{
    //    static void Main(string[] args)
    //    {
    //        string currentInputString = Console.ReadLine() ?? "abc";

    //        while (currentInputString != "end")
    //        {
    //            string currentInputStringReversed = Reverse(currentInputString);
    //            Console.WriteLine($"{currentInputString} = {currentInputStringReversed}");
    //            currentInputString = Console.ReadLine() ?? "abc";
    //        }
    //    }

    //    public static string Reverse(string s)
    //    {
    //        char[] charArray = s.ToCharArray();
    //        Array.Reverse(charArray);
    //        return new string(charArray);
    //    }
    //}

    //static void Main()
    //{
    //    List<string> reversedWords = new List<string>();

    //    while (true)
    //    {
    //        string input = Console.ReadLine();

    //        if (input == "end")
    //            break;

    //        string reversedWord = ReverseString(input);
    //        reversedWords.Add($"{input} = {reversedWord}");
    //    }

    //    foreach (string pair in reversedWords)
    //    {
    //        Console.WriteLine(pair);
    //    }
    //}

    //static string ReverseString(string input)
    //{
    //    string reversedWord = "";
    //    for (int i = input.Length - 1; i >= 0; i--)
    //    {
    //        reversedWord += input[i];
    //    }
    //    return reversedWord;
    //}

    //static void Main()
    //{
    //    string word = Console.ReadLine();

    //    while (word != "end")
    //    {
    //        string reversedWord = "";

    //        for (int i = word.Length -1; i >= 0; i--)
    //        {
    //            reversedWord += word[i];
    //        }

    //        Console.WriteLine($"{word} = {reversedWord}");

    //        word = Console.ReadLine();
    //    }
    //}

    static void Main()
    {
        string word = Console.ReadLine();

        while (word != "end")
        {

            char[] wordsAsCharArray = word.ToCharArray();
            Array.Reverse(wordsAsCharArray);

            string reversedWord = string.Join("", wordsAsCharArray);

            Console.WriteLine($"{word} = {reversedWord}");

            word = Console.ReadLine();
        }
    }

}
