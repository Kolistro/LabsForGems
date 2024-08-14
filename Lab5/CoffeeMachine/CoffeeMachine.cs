using CoffeeMachine.Tests;

namespace CoffeeMachine
{
    public class CoffeeMachine
    {
        private Dictionary<RecipeName, Recipe> _dictionaryRecipe;
        private GrinderUnit _grinderUnit;
        private BrewingUnit _brewingUnit;
        private Container _waterContainer;
        private Container _milkContainer;
        private Container _beansContainer;

        public CoffeeMachine(Container waterContainer, Container milkContainer, Container beansContainer)
        {
            _dictionaryRecipe = new Dictionary<RecipeName, Recipe>();
            _dictionaryRecipe.Add(RecipeName.Espresso, new Recipe(30, 0, 10));
            _dictionaryRecipe.Add(RecipeName.Cappuccino, new Recipe(30, 40, 10));
            _dictionaryRecipe.Add(RecipeName.Latte, new Recipe(30, 60, 10));
            _dictionaryRecipe.Add(RecipeName.Americano, new Recipe(70, 0, 20));

            _grinderUnit = new GrinderUnit();
            _brewingUnit = new BrewingUnit();

            _waterContainer = waterContainer;
            _milkContainer = milkContainer;
            _beansContainer = beansContainer;
        }
        public Coffee Brew(RecipeName recipeName)
        {
            Recipe recipe = _dictionaryRecipe[recipeName];
            
            int water = _waterContainer.GetResource(recipe.Water);
            int milk = _milkContainer.GetResource(recipe.Milk);
            int beans = _beansContainer.GetResource(recipe.Beans);

            GroundCoffee groundCoffee = _grinderUnit.Grind(beans);
            Coffee coffee = _brewingUnit.Brew(groundCoffee);

            coffee.Recipe = recipeName;

            return coffee;
        }

        public int GetWaterLevel() => _waterContainer.Value;

        public int GetMilkLevel() => _milkContainer.Value;

        public int GetBeansLevel() => _beansContainer.Value;

        public void LoadWater(int resource) => _waterContainer.LoadResource(resource);

        public void LoadMilk(int resource) => _milkContainer.LoadResource(resource);
        public void LoadBeans(int resource) => _beansContainer.LoadResource(resource);


    }
}
