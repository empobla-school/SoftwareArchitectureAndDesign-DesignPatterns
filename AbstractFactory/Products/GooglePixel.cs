using Factory.Interfaces;

namespace Factory.Products
{
    class GooglePixel : IPhone
    {
        public void PowerOn()
        {
            Console.WriteLine("Google Pixel is powering on...");
        }

        public void PowerOff()
        {
            Console.WriteLine("Google Pixel is powering off...");
        }

        public void CallSomeone()
        {
            Console.WriteLine("Google Pixel is calling someone...");
        }
    }
}