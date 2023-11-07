namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string key = Console.ReadLine();
            string text = Console.ReadLine();

            int index = text.IndexOf(key);

            while (index != -1)
            {
                text = text.Remove(index, key.Length);
                index = text.IndexOf(key);
            }

            Console.WriteLine(text);

            //    string stringToBeRemoved = Console.ReadLine() ?? "ice";
            //    string stringInput = Console.ReadLine() ?? "kicegiciceeb";


            //    while (true)
            //    {
            //        if (!stringInput.Contains(stringToBeRemoved))
            //        {
            //            break;
            //        }
            //        stringInput = stringInput.Replace(stringToBeRemoved, "");
            //    }

            //    Console.WriteLine(stringInput);
        }
    }
}