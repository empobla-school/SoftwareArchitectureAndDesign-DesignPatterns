using Factory.Interfaces;
using Factory.Products;

namespace Factory
{
    class GoogleFactory : ITechProductFactory
    {
        public IComputer createComputer()
        {
            return new GoogleChromebook();
        }
        
        public IPhone createPhone()
        {
            return new GooglePixel();
        }
    }
}