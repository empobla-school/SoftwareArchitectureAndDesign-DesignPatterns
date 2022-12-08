namespace AnimalFactory.Factory.Creators
{
    internal class AnimalCreator
    {
        internal static IAnimal Factory(string type)
        {
            IAnimal animalInterface;

            if (type == "eagle")
            {
                animalInterface = new Eagle();
            }

            else if (type == "dog")
            {
                animalInterface = new Dog(); 
            }

            else
            {
                throw new NotImplementedException();
            }

            return animalInterface;
        }
    }
}