using Factory.Interfaces;

namespace Factory.Products
{
    class iMac : IComputer
    {
        public void PowerOn()
        {
            Console.WriteLine("iMac is powering on...");
        }

        public void PowerOff()
        {
            Console.WriteLine("iMac is powering off...");
        }

        public void CreateAProgram()
        {
            Console.WriteLine("iMac is creating a program...");
        }
    }
}