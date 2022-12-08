using Prototype.Classes;

namespace Prototype
{
    class Prototype
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John Doe", "CEO", 150000);
            Console.WriteLine(employee.ToString());

            Employee employeeClone = (Employee) employee.clone();
            Console.WriteLine(employeeClone.ToString());
        }
    }
}