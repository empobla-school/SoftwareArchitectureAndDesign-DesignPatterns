namespace BuilderPattern.Interfaces
{
    interface Builder
    {
        void reset();
        void addScreen(string type);
        void addCase(string type);
        void addMotherboard();
        void addCPU(string type, int generation);
        void addGPU(string type);
        void addRAM(int capacity);
        void addStorage(string type, int capacity);
        void addCooling(string type);
    }
}