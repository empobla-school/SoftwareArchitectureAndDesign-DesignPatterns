using Factory.Interfaces;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apple Factory
            ITechProductFactory factory = new AppleFactory();
            CallPhoneMethods(factory);
            CallComputerMethods(factory);

            Console.WriteLine();

            // Google Factory
            factory = new GoogleFactory();
            CallPhoneMethods(factory);
            CallComputerMethods(factory);
        }

        static void CallPhoneMethods(ITechProductFactory factory)
        {
            IPhone phone = factory.createPhone();
            phone.PowerOn();
            phone.CallSomeone();
            phone.PowerOff();
        }
        
        static void CallComputerMethods(ITechProductFactory factory)
        {
            IComputer computer = factory.createComputer();
            computer.PowerOn();
            computer.CreateAProgram();
            computer.PowerOff();
        }
    }
}