namespace _32.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resourceOrStop = Console.ReadLine();

            Dictionary<string, int> ResourceQuantity = new Dictionary<string, int>();

            while (resourceOrStop != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                string resource = resourceOrStop;

                if (!ResourceQuantity.ContainsKey(resource))
                {
                    ResourceQuantity.Add(resource, quantity);
                }
                else
                {
                    ResourceQuantity[resource] += quantity;
                }

                resourceOrStop = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> pair in ResourceQuantity)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}

