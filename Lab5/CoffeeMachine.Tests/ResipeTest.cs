namespace CoffeeMachine.Tests
{
    public class ResipeTest
    {
        [Fact]
        public void CreateRecipe_WhithGivenNormalArguments_Success()
        {
            // Arange.
            const int water = 1;
            const int milk = 1;
            const int beans = 1;

            // Act.
            var recipe = new Recipe(water, milk, beans);
            
            // Assert.
            Assert.Equal(water, recipe.Water);
            Assert.Equal(milk, recipe.Milk);
            Assert.Equal(beans, recipe.Beans);
        }

        [Theory]
        [InlineData(1, 1, -1)]
        [InlineData(1, -1, 1)]
        [InlineData(-1, 1, 1)]
        [InlineData(301, 1, 1)]
        [InlineData(1, 301, 1)]
        [InlineData(1, 1, 51)]
        public void CreateRecipe_WhithInvalidArguments_Throws(int water, int milk, int beans)
        {
            // Act + Assert.
            Assert.Throws<ArgumentException>(() => new Recipe(water, milk, beans));
        }
    }
}
