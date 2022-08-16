using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Recipe
    {
        public int water;
        public int milk;
        public int beans;

        public Recipe(int water, int milk, int beans)
        {
            if (water < 0 || beans < 1 || milk < 0)
                throw new ArgumentException();
            this.water = water;
            this.milk = milk;
            this.beans = beans;
        }
    }
}
