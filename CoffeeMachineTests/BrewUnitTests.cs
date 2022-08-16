using CoffeeMachine;
using Xunit;
using System;

namespace CoffeeMachineTests
{
    public class BrewUnitTests
    {
        [Fact]
        public void BrewTests()
        {
            int quantity = 10;

            BrewUnit brewUnit = new BrewUnit();
            GroundCoffee coffee = new GroundCoffee();

            coffee.quantity = quantity;

            Coffee brewCoffee = brewUnit.Brew(coffee);
            
            Assert.Equal(0, coffee.quantity);           
        }



        
        

    }
}
