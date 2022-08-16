using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class CoffeeMachineUnit
    {

        private Dictionary<String, Recipe> _recipes;
        private GrinderUnit _grinderUnit;
        private BrewUnit _brewUnit;
        private Container _waterContainer;
        private Container _milkContainer;
        private Container _beansContainer;
        // Предустановленные рецепты:
        

        public CoffeeMachineUnit(Dictionary<string, Recipe> recipes, GrinderUnit grinderUnit, BrewUnit brewUnit, Container waterContainer, Container milkContainer, Container beansContainer)
        {
            if (recipes == null || grinderUnit == null || brewUnit == null || waterContainer == null || milkContainer == null || beansContainer == null)
                throw new ArgumentNullException();
            _recipes = recipes;
            _grinderUnit = grinderUnit;
            _brewUnit = brewUnit;
            _waterContainer = waterContainer;
            _milkContainer = milkContainer;
            _beansContainer = beansContainer;
        }


        public Coffee Brew(Recipe recipeName)
        {
            Coffee coffee = new Coffee();
            
            coffee = _brewUnit.Brew(_grinderUnit.Grind(_beansContainer.TakeResource(recipeName.beans)));
            _milkContainer.TakeResource(recipeName.milk);
            _waterContainer.TakeResource(recipeName.water);
            coffee.recipeName = recipeName;
            return coffee;
        }
        public void LoadWater(int quantity)
        {
            _waterContainer.LoadResource(quantity);
        }
        public void LoadMilk(int quantity)
        {
            _milkContainer.LoadResource(quantity);
        }
        public void LoadBeans(int quantity)
        {
            _beansContainer.LoadResource(quantity);
        }

        public int getWaterLevel()
        {
            return _waterContainer.getResourseLevel();
        }
        public int getMilkLevel()
        {
            return _milkContainer.getResourseLevel();
        }
        public int getBeansLevel()
        {
            return _beansContainer.getResourseLevel();
        }
    }
}
