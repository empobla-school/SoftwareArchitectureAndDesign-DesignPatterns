namespace Factory.Interfaces
{
    interface ITechProductFactory
    {
        IComputer createComputer();
        IPhone createPhone();
    }
}