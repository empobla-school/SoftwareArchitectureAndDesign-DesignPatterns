using Factory.Interfaces;
using Factory.Products;

namespace Factory
{
    class AppleFactory : ITechProductFactory
    {
        public IComputer createComputer()
        {
            return new iMac();
        }
        
        public IPhone createPhone()
        {
            return new iPhone();
        }
    }
}