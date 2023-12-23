﻿using System;
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

        public Animal ReadAnimal(string animalInput)
        {
            string[] animalParams = animalInput.Split(' ').ToArray();
            if (animalParams[0] == "Cat")
            {
                string name = animalParams[1];
                double weight = double.Parse(animalParams[2]);
                string livingRegion = animalParams[3];
                string breed = animalParams[4];

                Cat cat = new(name, weight, livingRegion, breed);
                return cat;
            }

            else if (animalParams[0] == "Tiger")
            {
                string name = animalParams[1];
                double weight = double.Parse(animalParams[2]);
                string livingRegion = animalParams[3];
                string breed = animalParams[4];

                Tiger tiger = new(name, weight, livingRegion, breed);
                return tiger;
            }

            else if (animalParams[0] == "Owl")
            {
                string name = animalParams[1];
                double weight = double.Parse(animalParams[2]);
                double wingSize = double.Parse(animalParams[3]);

                Owl owl = new(name, weight, wingSize);
                return owl;
            }

            else if (animalParams[0] == "Hen")
            {
                string name = animalParams[1];
                double weight = double.Parse(animalParams[2]);
                double wingSize = double.Parse(animalParams[3]);

                Hen hen = new(name, weight, wingSize);
                return hen;
            }

            else if (animalParams[0] == "Mouse")
            {
                string name = animalParams[1];
                double weight = double.Parse(animalParams[2]);
                string livingRegion = animalParams[3];

                Mouse mouse = new(name, weight, livingRegion);
                return mouse;
            }

            else if (animalParams[0] == "Dog")
            {
                string name = animalParams[1];
                double weight = double.Parse(animalParams[2]);
                string livingRegion = animalParams[3];

                Dog dog = new(name, weight, livingRegion);
                return dog;
            }
            else
             throw new ArgumentException();
        }

        public Food ReadFood (string foodInput)
        {
            string[] foodParams = foodInput.Split().ToArray();
            string foodName = foodParams[0];
            int foodQuantity = int.Parse(foodParams[1]);

            if (foodParams[0] == "Vegetable")
            {
                return new Vegetable(foodQuantity);
            }
            else if (foodParams[0] == "Meat")
            {
                return new Meat(foodQuantity);
            }
            else if (foodParams[0] == "Fruit")
            {
                return new Fruits(foodQuantity);
            }
            else if (foodParams[0] == "Seeds")
            {
                return new Seeds(foodQuantity);
            }
            else
                throw new ArgumentException();
        }
        public void FeedAnimal(Animal animal, Food food)
        {
            animal.Talk();
            if (animal.GetType().Name == "Hen")
            {
                animal.Weight += food.Quantity * 0.35;
            }
            else if (animal.GetType().Name == "Owl")
            {
                if (food.GetType().Name != "Meat")
                {
                    throw new ArgumentException();
                }
                animal.Weight += food.Quantity * 0.25;
            }
            else if (animal.GetType().Name == "Mouse")
            {
                if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Fruit")
                {
                    throw new ArgumentException();
                }
                animal.Weight += food.Quantity * 0.10;
            }
            else if (animal.GetType().Name == "Cat")
            {
                if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Meat")
                {
                    throw new ArgumentException();
                }
                animal.Weight += food.Quantity * 0.30;
            }
            else if (animal.GetType().Name == "Dog")
            {
                if (food.GetType().Name != "Meat")
                {
                    throw new ArgumentException();
                }
                animal.Weight += food.Quantity * 0.40;
            }
            else if (animal.GetType().Name == "Tiger")
            {
                if (food.GetType().Name != "Meat")
                {
                    throw new ArgumentException();
                }
                animal.Weight += food.Quantity * 1.00;
            }
            animal.FoodEaten += food.Quantity;
        }


    }
}
