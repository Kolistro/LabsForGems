namespace CoffeeMachine.Tests
{
    public class BrewingUnitTest
    {
        [Fact]
        public void Brew_Success()
        {
            // Arange.
            var brewingUnit = new BrewingUnit();
            var groundCoffee = new GroundCoffee(10);

            var expectedCoffee = new Coffee();

            // Act.
            Coffee coffee = brewingUnit.Brew(groundCoffee);

            // Assert.
            Assert.NotNull(coffee);
            Assert.Equal(expectedCoffee.Recipe, coffee.Recipe);

        }
    }
}
