using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animal.Mammal
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }
        protected Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
