using BuilderPattern.Interfaces;

namespace BuilderPattern.Directors
{
    class Director
    {
        public void constructLaptop(Builder builder) 
        {
            builder.reset();
            builder.addMotherboard();
            builder.addCPU("intel", 5);
            builder.addGPU("integrated");
            builder.addRAM(8);
            builder.addStorage("ssd", 512);
            builder.addCooling("air");
            builder.addCase("laptop");
            builder.addScreen("laptop");
        }

        public void constructDesktop(Builder builder)
        {
            builder.reset();
            builder.addMotherboard();
            builder.addCPU("intel", 7);
            builder.addGPU("nvidia");
            builder.addRAM(32);
            builder.addStorage("ssd", 1024);
            builder.addStorage("hdd", 2048);
            builder.addCooling("liquid");
            builder.addCase("tower");
            builder.addScreen("monitor");
            builder.addScreen("monitor");
        }
    }
}