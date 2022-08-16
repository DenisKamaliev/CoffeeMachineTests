using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class BrewUnit
    {
        public Coffee Brew (GroundCoffee groundCoffee)
        {
            Coffee coffee = new Coffee ();
            groundCoffee.quantity = 0;
            return coffee;
        }
    }
}
