namespace DatabaseSpace
{
    class Database
    {
        private static Database? instance;

        private List<string> employeeIds;
        private Dictionary<string, string> employeeNames;
        private Dictionary<string, double> employeeSalaries;

        private Database()
        {
            employeeIds = new List<string>();
            employeeNames = new Dictionary<string, string>();
            employeeSalaries = new Dictionary<string, double>();
        }

        public static Database GetInstance()
        {
            if (instance == null)
            {
                instance = new Database();
                Console.WriteLine("New database created");
            }

            else
            {
                Console.WriteLine("Existing database returned");
            }

            return instance;
        }

        public override string ToString()
        {
            if (employeeIds.Count == 0) 
                return "Database is empty\n";

            string output = "ID\t\tName\t\tSalary\n";
            
            for (int i = 0; i < employeeIds.Count; i++)
            {
                string employeeId = employeeIds[i];
                string employeeName = employeeNames[employeeId];
                double employeeSalary = employeeSalaries[employeeId];

                output += string.Format("{0}\t{1}\t{2}\n", employeeId, employeeName, employeeSalary);
            }

            return output;
        }

        private string GenerateRandomId()
        {
            string[] ingredients = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,1,2,3,4,5,6,7,8,9,0,@,#,<,>,!,£,$,%,^,&,*".Split(',');
            string randomId = "";

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                string randomIngredient = ingredients[rnd.Next(ingredients.Length)];
                randomId += randomIngredient;
            }

            return randomId;
        }

        public void CreateEmployee(string name, double salary)
        {
            string employeeId = GenerateRandomId();

            while (employeeIds.Contains(employeeId))
                employeeId = GenerateRandomId();

            employeeIds.Add(employeeId);
            employeeNames.Add(employeeId, name);
            employeeSalaries.Add(employeeId, salary);
        }
    }
}