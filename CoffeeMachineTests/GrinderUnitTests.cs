using CoffeeMachine;
using Xunit;
using System;

namespace CoffeeMachineTests
{
    public class GrinderUnitTests
    {
        [Fact]
        public void GrindTest()
        {
            int quantity = 10;
            GrinderUnit grinderUnit = new GrinderUnit();
            GroundCoffee coffee = new GroundCoffee();
            coffee.quantity = quantity;
            Assert.Equal(coffee.quantity, grinderUnit.Grind(quantity).quantity);          
        }
    }
}
