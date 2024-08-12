namespace CoffeeMachine.Tests
{
    public class CoffeeMachineTest
    {
        readonly CoffeeMachine _coffeeMachine;
        public CoffeeMachineTest() { 
            
            Container waterContainer = new Container(1000);
            Container milkContainer = new Container(1000);
            Container beansContainer = new Container(1000);

            _coffeeMachine = new CoffeeMachine(waterContainer, milkContainer, beansContainer);
        }

        [Fact]
        public void LoadWaterAndGetWaterLevel_NormalValue_Success()
        { 
            // Arrange.
            const int resource = 1000;

            // Act.
            _coffeeMachine.LoadWater(resource);

            // Assert.
            Assert.Equal(resource, _coffeeMachine.GetWaterLevel());
        }

        [Fact]
        public void LoadMilkAndGetMilkLevel_NormalValue_Success()
        {
            // Arrange.
            const int resource = 1000;

            // Act.
            _coffeeMachine.LoadMilk(resource);

            // Assert.
            Assert.Equal(resource, _coffeeMachine.GetMilkLevel());

        }

        [Fact]
        public void LoadBeansAndGetBeansLevel_NormalValue_Success()
        {
            // Arrange.
            const int resource = 1000;

            // Act.
            _coffeeMachine.LoadBeans(resource);

            // Assert.
            Assert.Equal(resource, _coffeeMachine.GetBeansLevel());

        }

        [Fact]
        public void Brew_Success()
        {
            // Arrange.
            const int resource = 1000;
            _coffeeMachine.LoadWater(resource);
            _coffeeMachine.LoadMilk(resource);
            _coffeeMachine.LoadBeans(resource);

            const RecipeName recipeName = RecipeName.LATTE;

            // Act.
            Coffee coffee = _coffeeMachine.Brew(recipeName);

            // Assert.
            Assert.NotNull(coffee);
            Assert.Equal(recipeName, coffee.Recipe);
        }

        [Fact]
        public void Brew_RecipeNameIsLATTE_QuantityWaterInContainerDecreased() {
            // Arrange.
            const int resource = 1000;
            _coffeeMachine.LoadWater(resource);
            _coffeeMachine.LoadMilk(resource);
            _coffeeMachine.LoadBeans(resource);

            const int value = 970;

            // Act.
            Coffee coffee = _coffeeMachine.Brew(RecipeName.LATTE);

            // Assert.
            Assert.Equal(value, _coffeeMachine.GetWaterLevel());
        }

        [Fact]
        public void Brew_RecipeNameIsLATTE_QuantityMilkInContainerDecreased()
        {
            // Arrange.
            const int resource = 1000;
            _coffeeMachine.LoadWater(resource);
            _coffeeMachine.LoadMilk(resource);
            _coffeeMachine.LoadBeans(resource);

            const int value = 940;

            // Act.
            Coffee coffee = _coffeeMachine.Brew(RecipeName.LATTE);

            // Assert.
            Assert.Equal(value, _coffeeMachine.GetMilkLevel());
        }

        [Fact]
        public void Brew_RecipeNameIsLATTE_QuantityBeansInContainerDecreased()
        {
            // Arrange.
            const int resource = 1000;
            _coffeeMachine.LoadWater(resource);
            _coffeeMachine.LoadMilk(resource);
            _coffeeMachine.LoadBeans(resource);

            const int value = 990;

            // Act.
            Coffee coffee = _coffeeMachine.Brew(RecipeName.LATTE);

            // Assert.
            Assert.Equal(value, _coffeeMachine.GetBeansLevel());
        }

        [Theory]
        [InlineData(1, 60, 10)]
        [InlineData(30, 1, 10)]
        [InlineData(30, 60, 1)]
        public void Brew_EntireResourceFromContainerIsUsed_Throws(
            int resourceWater,
            int resourceMilk,
            int resourceBeans)
        {
            // Arrange.
            _coffeeMachine.LoadWater(resourceWater);
            _coffeeMachine.LoadMilk(resourceMilk);
            _coffeeMachine.LoadBeans(resourceBeans);

            // Act + Assert.
            Assert.Throws<ArgumentException>(() => _coffeeMachine.Brew(RecipeName.LATTE));
        }

    }
}
