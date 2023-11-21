namespace _43.StoreBoxes
{
    internal class Program
    {

        public class Item
        {
            public Item(string name, decimal price)
            {
                Name = name;
                Price = price;
            }
            public string Name { get; set; }

            public decimal Price { get; set; }

        }

        public class Box
        {
            public Box(string serialNumber, Item itemName, int itemQuantity)
            {
                SerialNumber = serialNumber;
                ItemQuantity = itemQuantity;
                Item = itemName;
                PriceForABox = Item.Price * itemQuantity;
            }

            public string SerialNumber { get; set; }

            public Item Item { get; set; }

            public int ItemQuantity { get; set; }

            public decimal PriceForABox { get; set; }

        }


        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>();  

            while (command != "end")
            {
                string[] data = command.Split().ToArray();

                string currentSerialNumber = data[0];
                string currentItemName = data[1];
                int currentQuantity = int.Parse(data[2]);
                decimal currentPrice = decimal.Parse(data[3]);

                Item currentItem = new Item(currentItemName, currentPrice);

                Box currentBox = new Box(currentSerialNumber, currentItem, currentQuantity);

                boxes.Add(currentBox);

                command = Console.ReadLine();
            }

            boxes = boxes
                    .OrderByDescending(box => box.PriceForABox)
                    .ToList();

            foreach (var box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} – ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox}");

            }
        }
    }
}