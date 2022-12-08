namespace BuilderPattern.Classes
{
    class ComputerManual
    {
        List<string> Screen = new List<string>();
        string Case = "";
        string Motherboard = "";
        string CPU = "";
        string GPU = "";
        string RAM = "";
        List<string> Storage = new List<string>();
        string Cooling = "";

        public void addScreen(string screen)
        {
            Screen.Add(screen);
        }

        public void setCase(string type)
        {
            Case = type;
        }

        public void addMotherboard()
        {
            Motherboard = "ASUS Zen";
        }

        public void setCPU(string cpu, int generation)
        {

            CPU = String.Format("{0} i{1}", cpu, generation);
        }

        public void setGPU(string gpu)
        {
            GPU = gpu;
        }

        public void setRAM(int capacity)
        {
            RAM = String.Format("{0} GB", capacity);
        }

        public void addStorage(string type, int capacity)
        {
            Storage.Add(String.Format("{0} GB {1}", capacity, type));
        }

        public void setCooling(string cooling)
        {
            Cooling = cooling;
        }

        public override string ToString()
        {
            string specs = "";

            if (Screen.Count > 0)
                specs += Screen.Count == 1 
                    ? String.Format("Screen Manual: {0}\n", Screen[0])
                    : String.Format("Screen Manuals: {0}\n", String.Join(", ", Screen.ToArray()));

            if (Case != "")
                specs += String.Format("Case Manual: {0}\n", Case);
            
            if (Motherboard != "")
                specs += String.Format("Motherboard Manual: {0}\n", Motherboard);

            if (CPU != "")
                specs += String.Format("CPU Manual: {0}\n", CPU);
            
            if (GPU != "")
                specs += String.Format("GPU Manual: {0}\n", GPU);
            
            if (RAM != "")
                specs += String.Format("RAM Manual: {0}\n", RAM);
            
            if (Storage.Count > 0)
                specs += String.Format("Storage Manual: {0}\n", String.Join(", ", Storage.ToArray()));

            if (Cooling != "")
                specs += String.Format("Cooling Manual: {0}\n", Cooling);

            if (specs == "")
                return "No computer manual built";
            
            return specs;
        }
    }
}