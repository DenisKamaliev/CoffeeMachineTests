using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class GrinderUnit
    {
        public GroundCoffee Grind (int quantity)
        {
            GroundCoffee groundCoffee = new GroundCoffee();
            groundCoffee.quantity = quantity;
            return groundCoffee;
        }
    }
}
