using BuilderPattern.Classes;
using BuilderPattern.Interfaces;

namespace BuilderPattern.Builders
{
    class ComputerBuilder : Builder
    {
        Computer computer = new Computer();

        public void reset()
        {
            computer = new Computer();
        }

        public void addScreen(string type)
        {
            computer.addScreen(type);
        }

        public void addCase(string type)
        {
            computer.setCase(type);
        }

        public void addMotherboard()
        {
            computer.addMotherboard();
        }

        public void addCPU(string type, int generation)
        {
            computer.setCPU(type, generation);
        }

        public void addGPU(string type)
        {
            computer.setGPU(type);
        }

        public void addRAM(int capacity)
        {
            computer.setRAM(capacity);
        }

        public void addStorage(string type, int capacity)
        {
            computer.addStorage(type, capacity);
        }

        public void addCooling(string type)
        {
            computer.setCooling(type);
        }

        public Computer getResult()
        {
            return computer;
        }
    }
}