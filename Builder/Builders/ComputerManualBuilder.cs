using BuilderPattern.Classes;
using BuilderPattern.Interfaces;

namespace BuilderPattern.Builders
{
    class ComputerManualBuilder : Builder
    {
        ComputerManual manual = new ComputerManual();

        public void reset()
        {
            manual = new ComputerManual();
        }

        public void addScreen(string type)
        {
            manual.addScreen(type);
        }

        public void addCase(string type)
        {
            manual.setCase(type);
        }

        public void addMotherboard()
        {
            manual.addMotherboard();
        }

        public void addCPU(string type, int generation)
        {
            manual.setCPU(type, generation);
        }

        public void addGPU(string type)
        {
            manual.setGPU(type);
        }

        public void addRAM(int capacity)
        {
            manual.setRAM(capacity);
        }

        public void addStorage(string type, int capacity)
        {
            manual.addStorage(type, capacity);
        }

        public void addCooling(string type)
        {
            manual.setCooling(type);
        }

        public ComputerManual getResult()
        {
            return manual;
        }
    }
}