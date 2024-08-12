
namespace CoffeeMachine.Tests
{
    public class Coffee
    {
        public RecipeName Recipe { get; set; }

        public Coffee()
        {
            Recipe = RecipeName.ESPRESSO;
        }
    }
}