using BuilderPattern.Directors;
using BuilderPattern.Builders;
using BuilderPattern.Classes;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            
            ComputerBuilder builder = new ComputerBuilder();
            ComputerManualBuilder manualBuilder = new ComputerManualBuilder();

            // Construct laptop with manual
            director.constructLaptop(builder);
            Computer laptop = builder.getResult();
            director.constructLaptop(manualBuilder);
            ComputerManual laptopManual = manualBuilder.getResult();

            // Construct desktop with manual
            director.constructDesktop(builder);
            Computer desktop = builder.getResult();
            director.constructDesktop(manualBuilder);
            ComputerManual desktopManual = manualBuilder.getResult();

            Console.WriteLine(laptop.ToString());
            Console.WriteLine(laptopManual.ToString());
            Console.WriteLine(desktop.ToString());
            Console.WriteLine(desktopManual.ToString());
        }
    }
}