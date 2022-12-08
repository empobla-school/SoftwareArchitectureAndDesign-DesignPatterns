namespace AnimalFactory.Factory
{
    internal class Dog : IAnimal
    {
        public void Hunt()
        {
            Console.WriteLine("Dog is hunting");
        }

        public void Move()
        {
            Console.WriteLine("Dog is walking");
        }

        public void Sleep()
        {
            Console.WriteLine("Dog is sleeping");
        }
        
        public void Communicate()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}