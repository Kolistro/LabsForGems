namespace CoffeeMachine.Tests
{
    public class Recipe
    {
        const int MIN_RESOURCE = 0;
        const int MAX_WATER = 300;
        const int MAX_MILK = 300;
        const int MAX_BEANS = 50;
        public int Water { get; set; }
        public int Milk { get; set; }
        public int Beans { get; set; }

        public Recipe(int water, int milk, int beans)
        {
            if (water < MIN_RESOURCE || water > MAX_WATER) 
                throw new ArgumentException($"Количество воды должно быть в пределах {MIN_RESOURCE}-{MAX_WATER}.", nameof(water));

            if (milk < MIN_RESOURCE || milk > MAX_MILK) 
                throw new ArgumentException($"Количество молока должно быть в пределах {MIN_RESOURCE}-{MAX_MILK}.", nameof(milk));

            if (beans < MIN_RESOURCE || beans > MAX_BEANS) 
                throw new ArgumentException($"Количество зёрен должно быть в пределах {MIN_RESOURCE}-{MAX_BEANS}.", nameof(beans));

            Water = water;
            Milk = milk;
            Beans = beans;
        }
    }
}