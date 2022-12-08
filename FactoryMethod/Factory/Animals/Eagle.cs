namespace AnimalFactory.Factory
{
    internal class Eagle : IAnimal
    {
        public void Hunt()
        {
            Console.WriteLine("Eagle is hunting");
        }

        public void Move()
        {
            Console.WriteLine("Eagle is flying");
        }

        public void Sleep()
        {
            Console.WriteLine("Eagle is sleeping");
        }
        
        public void Communicate()
        {
            Console.WriteLine("Gawk Gawk");
        }
    }
}