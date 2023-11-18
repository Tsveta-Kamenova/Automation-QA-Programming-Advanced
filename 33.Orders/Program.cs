namespace _33.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<decimal>> productPricesDict = new();

            while (input != "buy")
            {

                string[] inputArray = input.Split();
                string product = inputArray[0];
                decimal price = decimal.Parse(inputArray[1]);
                decimal quantity = decimal.Parse(inputArray[2]);

                if (!productPricesDict.ContainsKey(product))
                {
                    productPricesDict.Add(product, new() { price, quantity});

                    //productPricesDict.Add(product, new List<double>());
                    //productPricesDict[product].Add(price);
                    //productPricesDict[product].Add(quantity);
                }
                else
                {
                    productPricesDict[product][0] = price;
                    productPricesDict[product][1] += quantity;
                }

                input = Console.ReadLine();
            }
            
            foreach (KeyValuePair<string, List<decimal>> currentProduct in productPricesDict)
            {
                string currentProductName = currentProduct.Key;
                decimal currentPrice = currentProduct.Value[0];
                decimal currentQuantity = currentProduct.Value[1];

                decimal totalPrice = currentPrice * currentQuantity;

                Console.WriteLine($"{currentProductName} -> {totalPrice:f2}");
            }
        }
    }
}