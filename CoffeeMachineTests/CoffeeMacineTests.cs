using CoffeeMachine;
using Xunit;
using System;
using System.Collections.Generic;

namespace CoffeeMachineTests
{
    public class CoffeeMacineTests
    {
        [Fact]
        public void WorkingTest()
        {
            
            Dictionary<String, Recipe> recipes = new Dictionary<string, Recipe>();
            Recipe recipe = new Recipe(1, 1, 1);
            recipes.Add("test", recipe);
            GrinderUnit grinderUnit = new GrinderUnit();
            BrewUnit brewUnit = new BrewUnit();
            Container waterContainer = new Container(3000);
            Container milkContainer = new Container(3000);
            Container beansContainer = new Container(3000);

            Recipe _cappuccino = new Recipe(10, 20, 10);
            Recipe _espresso = new Recipe(30, 0, 20);
            Recipe _filtered = new Recipe(20, 0, 10);

            recipes.Add("filtered", _filtered);
            recipes.Add("cappuccino", _cappuccino);
            recipes.Add("espresso", _espresso);

            Coffee cappucino = new Coffee();
            cappucino.recipeName = _cappuccino;

            CoffeeMachineUnit coffeeMachine = new CoffeeMachineUnit(recipes, grinderUnit, brewUnit, waterContainer, milkContainer, beansContainer);

            coffeeMachine.LoadWater(1000);
            coffeeMachine.LoadMilk(1000);
            coffeeMachine.LoadBeans(1000);



            Assert.Equal(cappucino.recipeName, coffeeMachine.Brew(_cappuccino).recipeName);
        }
    }
}
