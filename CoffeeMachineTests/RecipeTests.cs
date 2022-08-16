using CoffeeMachine;
using Xunit;
using System;

namespace CoffeeMachineTests
{
    public class RecipeTests
    {
        [Fact]
        public void RecipeCreate_Success()
        {
            Recipe recipe = new Recipe(1, 2, 3);
            Assert.Equal(1, recipe.water);
            Assert.Equal(2, recipe.milk);
            Assert.Equal(3, recipe.beans);
        }

        [Fact]
        public void RecipeCreate_TThrowsException()
        {

            Assert.Throws<ArgumentException>(() => new Recipe(-1, 3, 3));
            Assert.Throws<ArgumentException>(() => new Recipe(3, -1, 3));
            Assert.Throws<ArgumentException>(() => new Recipe(3, 3, -1));
        }
    }
}
