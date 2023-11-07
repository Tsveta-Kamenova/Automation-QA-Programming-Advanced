namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = (Console.ReadLine()?? "a").Split(", ");
            string textToBeChanged = Console.ReadLine() ?? "abc";

            foreach (var banWord in banWords)
            {
                if (textToBeChanged.Contains(banWord))
                {
                    textToBeChanged = textToBeChanged.Replace(banWord, new string('*', banWord.Length));
                }
            }
            Console.WriteLine(textToBeChanged);
        }
    }
}