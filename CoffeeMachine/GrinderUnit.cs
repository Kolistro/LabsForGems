namespace CoffeeMachine.Tests
{
    public class GrinderUnit
    {
        private int MinQuantity = 1;
        private int MaxQuantity = 100;

       public GroundCoffee Grind(int quantity)
       {
            if (quantity < MinQuantity || quantity > MaxQuantity) 
                throw new ArgumentException($"Количество кофе должно быть в пределах {MinQuantity}-{MaxQuantity}.", nameof(quantity));

            return new GroundCoffee(quantity);
       }
    }
}