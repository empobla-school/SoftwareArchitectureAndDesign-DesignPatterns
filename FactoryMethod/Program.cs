using AnimalFactory.Factory;
using AnimalFactory.Factory.Creators;

namespace AnimalFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal eagle = AnimalCreator.Factory("eagle");
            eagle.Hunt();
            eagle.Move();
            eagle.Sleep();
            eagle.Communicate();

            Console.WriteLine();

            IAnimal dog = AnimalCreator.Factory("dog");
            dog.Hunt();
            dog.Move();
            dog.Sleep();
            dog.Communicate();
        }
    }
}