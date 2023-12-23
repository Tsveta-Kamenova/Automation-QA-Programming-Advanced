using WildFarm.Animals;
using WildFarm.Animals.Mammals.Felines;
using WildFarm.Foods;

namespace WildFarm
{
    public class Program
    {

        static void Main(string[] args)
        {
            Farm farm = new Farm();

            string animalInput = Console.ReadLine();
            string foodInput = Console.ReadLine();
            string end = Console.ReadLine();

            Animal animal = farm.ReadAnimal(animalInput);
            Food food = farm.ReadFood(foodInput);
            farm.AddAnimal(animal);
            farm.FeedAnimal(animal, food);

        }
    }
}