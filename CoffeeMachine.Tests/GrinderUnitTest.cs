namespace CoffeeMachine.Tests
{
    public class GrinderUnitTest
    {
        [Fact]
        public void Grind_NormalQuantity_Success()
        {
            // Arrange.
            const int quantity = 10;
            var grinderUnit = new GrinderUnit();

            // Act.
            GroundCoffee groundCoffee = grinderUnit.Grind(quantity);
            var quantityGroundCoffee = groundCoffee.Quantity;

            // Assert.
            Assert.NotNull(quantityGroundCoffee);
            Assert.Equal(quantity, quantityGroundCoffee);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(101)]
        public void Grind_InvalidQuantity_Throws(int quantity)
        {
            // Arrange.
            var grinderUnit = new GrinderUnit();

            // Act + Assert.
            Assert.Throws<ArgumentException>(() => grinderUnit.Grind(quantity));
        }
    }
}
