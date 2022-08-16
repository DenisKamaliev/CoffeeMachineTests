namespace CoffeeMachine
{
    public class Container
    {
        private const int _maxCapacity = 3000;
        private int _resourseLevel { get; set; }
        public int Capacity { get; }

        public Container(int capacity)
        {
            if (capacity < 1 || capacity > _maxCapacity)
                throw new ArgumentException();
            _resourseLevel = 0;
            Capacity = capacity;
        }

        public void LoadResource ( int quantity)
        {
            if(quantity < 1 || quantity + _resourseLevel > Capacity)
                throw new ArgumentException();
            _resourseLevel += quantity;
        }

        public int TakeResource(int quantity)
        {
            if (quantity < 1 || quantity > _resourseLevel)
                throw new ArgumentException();
            _resourseLevel -= quantity;
            return quantity;
        }

        public int getResourseLevel()
        {
            return _resourseLevel;
        }


    }
}