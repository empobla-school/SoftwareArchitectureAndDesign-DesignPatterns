namespace DatabaseSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db0 = Database.GetInstance();
            Console.Write(db0.ToString());

            db0.CreateEmployee("Emilio Popovits", 45000);
            Console.Write(db0.ToString());

            Database db1 = Database.GetInstance();
            Console.Write(db1.ToString());

            db1.CreateEmployee("Ruben Raya", 100000);
            Console.Write(db1.ToString());
        }
    }
}