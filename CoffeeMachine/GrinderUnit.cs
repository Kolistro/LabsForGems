namespace CoffeeMachine.Tests
{
    public class GrinderUnit
    {
        private int MIN_QUANTITY = 1;
        private int MAX_QUANTITY = 100;

       public GroundCoffee Grind(int quantity)
       {
            if (quantity < MIN_QUANTITY || quantity > MAX_QUANTITY) 
                throw new ArgumentException(nameof(quantity));

            return new GroundCoffee(quantity);
       }
    }
}