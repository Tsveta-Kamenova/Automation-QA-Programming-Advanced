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
            
            while (animalInput != "End")
            {
                Animal animal = farm.ReadAnimal(animalInput);
                farm.AddAnimal(animal);
                Console.WriteLine(animal.Talk());

                string foodInput = Console.ReadLine();
                Food food = farm.ReadFood(foodInput);
                farm.FeedAnimal(animal, food);

                animalInput = Console.ReadLine();
            }


            foreach (Animal currentAnimal in farm.Animals)
            {
                Console.WriteLine(currentAnimal);
            }
        }
    }
}