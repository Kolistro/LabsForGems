namespace CoffeeMachine
{
    public class Container
    {
        private const int MinCapacity = 1;
        private const int MaxCapacity = 3000;

        private int _capacity;
        private int _value;

        public Container(int capacity)
        {
            if(capacity < MinCapacity || capacity > MaxCapacity)
                throw new ArgumentException($"Емкасть контейнера должна быть в пределах {MinCapacity}-{MaxCapacity}.", nameof(capacity));
            _capacity = capacity;
        }

        public void LoadResource(int resource)
        {
            int temp = _value + resource;
            if(resource < MinCapacity )
                throw new ArgumentException("Некорректное значение ресурса.",nameof(resource));
            if ( temp > _capacity)
                throw new ArgumentException("При добавлении ресурса, контейнер будет переполнен.", nameof(resource));

            _value += resource;
        }

        public int GetResource(int resource) 
        {
            if(resource > _value || resource < 0)
                throw new ArgumentException(nameof(resource));

            _value -= resource;
            
            return resource;
        }

        public int Capacity => _capacity;

        public int Value => _value;


    }
}
