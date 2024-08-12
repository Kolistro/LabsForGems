namespace CoffeeMachine
{
    public class Container
    {
        private const int MIN_CAPACITY = 1;
        private const int MAX_CAPACITY = 3000;

        private int _capacity;
        private int _value;

        public Container(int capacity)
        {
            if(capacity < MIN_CAPACITY || capacity > MAX_CAPACITY)
                throw new ArgumentException(nameof(capacity));
            _capacity = capacity;
        }

        public void LoadResource(int resource)
        {
            int temp = _value + resource;
            if(resource < MIN_CAPACITY || temp > _capacity)
                throw new ArgumentException(nameof(resource));

            _value += resource;
        }

        public int GetResource(int resource) 
        {
            if(resource > _value || resource < 0)
                throw new ArgumentException(nameof(resource));

            _value -= resource;
            
            return resource;
        }

        public int GetCapacity()
        {
            return _capacity;
        }

        public int GetValue()
        {
            return _value;
        }

       
    }
}
