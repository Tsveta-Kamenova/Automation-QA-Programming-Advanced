using WildFarm.Animal.Mammal.Feline;
using WildFarm.Food;

namespace WildFarm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Cat cat = new Cat("Sammy", 1.1, "Home", "Persian");
            Console.WriteLine(cat.Talk());

            Vegetable vegetable = new Vegetable(4);
            cat.FoodEaten += 4;
            cat.Weight += 4 * 0.30;
            Console.WriteLine(cat);
        }
    }
}