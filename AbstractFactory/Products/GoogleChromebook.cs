using Factory.Interfaces;

namespace Factory.Products
{
    class GoogleChromebook : IComputer
    {
        public void PowerOn()
        {
            Console.WriteLine("Google Chromebook is powering on...");
        }

        public void PowerOff()
        {
            Console.WriteLine("Google Chromebook is powering off...");
        }

        public void CreateAProgram()
        {
            Console.WriteLine("Google Chromebook is creating a program...");
        }
    }
}