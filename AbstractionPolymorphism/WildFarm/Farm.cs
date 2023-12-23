using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals;
using WildFarm.Animals.Mammals.Felines;
using WildFarm.Foods;

namespace WildFarm
{
    public class Farm
    {
        private List<Animal> _animals = new();

        public IReadOnlyCollection<Animal> Animals => _animals.AsReadOnly();

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public void CreateAnimal(string animalInput)
        {
            string[] animalParams = animalInput.Split(' ');
            if (animalParams[0] == "Cat")
            {
                string name = animalParams[1];
                double weight = double.Parse(animalParams[2]);
                string livingRegion = animalParams[3];
                string breed = animalParams[4];

                Cat cat = new(name, weight, livingRegion, breed);
                AddAnimal(cat);
            }

            else if (animalParams[0] == "Tiger")
            {
                string name = animalParams[1];
                double weight = double.Parse(animalParams[2]);
                string livingRegion = animalParams[3];
                string breed = animalParams[4];

                Tiger tiger = new(name, weight, livingRegion, breed);
                AddAnimal(tiger);
            }

            else if (animalParams[0] == "Owl")
            {
                string name = animalParams[1];
                double weight = double.Parse(animalParams[2]);
                double wingSize = double.Parse(animalParams[3]);

                Owl owl = new(name, weight, wingSize);
                AddAnimal(owl);
            }

            else if (animalParams[0] == "Hen")
            {
                string name = animalParams[1];
                double weight = double.Parse(animalParams[2]);
                double wingSize = double.Parse(animalParams[3]);

                Hen hen = new(name, weight, wingSize);
                AddAnimal(hen);
            }

            else if (animalParams[0] == "Mouse")
            {
                string name = animalParams[1];
                double weight = double.Parse(animalParams[2]);
                string livingRegion = animalParams[3];

                Mouse mouse = new(name, weight, livingRegion);
                AddAnimal(mouse);
            }

            else if (animalParams[0] == "Dog")
            {
                string name = animalParams[1];
                double weight = double.Parse(animalParams[2]);
                string livingRegion = animalParams[3];

                Dog dog = new(name, weight, livingRegion);
                AddAnimal(dog);
            }
        }
        public void FeedAnimal(Animal animal, Food food)
        {
            if (animal.GetType().Name == "Hen")
            {
                animal.Weight += food.Quantity * 0.35;
            }
            else if (animal.GetType().Name == "Owl")
            {
                animal.Weight += food.Quantity * 0.25;
            }
            else if (animal.GetType().Name == "Mouse")
            {
                animal.Weight += food.Quantity * 0.10;
            }
            else if (animal.GetType().Name == "Cat")
            {
                animal.Weight += food.Quantity * 0.30;
            }
            else if (animal.GetType().Name == "Dog")
            {
                animal.Weight += food.Quantity * 0.40;
            }
            else if (animal.GetType().Name == "Tiger")
            {
                animal.Weight += food.Quantity * 1.00;
            }
            animal.FoodEaten += food.Quantity;
        }


    }
}
