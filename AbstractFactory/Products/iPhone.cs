using Factory.Interfaces;

namespace Factory.Products
{
    class iPhone : IPhone
    {
        public void PowerOn()
        {
            Console.WriteLine("iPhone is powering on...");
        }

        public void PowerOff()
        {
            Console.WriteLine("iPhone is powering off...");
        }

        public void CallSomeone()
        {
            Console.WriteLine("iPhone is calling someone...");
        }
    }
}