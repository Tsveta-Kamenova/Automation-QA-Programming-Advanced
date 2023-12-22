using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animal
{
    public abstract class Animal: ITalk
    {
        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public abstract string Talk();
    }
}
