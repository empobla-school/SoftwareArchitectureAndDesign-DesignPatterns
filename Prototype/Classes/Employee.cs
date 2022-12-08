using Prototype.Interfaces;

namespace Prototype.Classes
{
    class Employee : EmployeePrototype
    {
        string name;
        string position;
        double salary;

        public Employee(string name, string position, double salary)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
        }

        private Employee(Employee employee)
        {
            this.name = employee.name;
            this.position = employee.position;
            this.salary = employee.salary;
        }

        public EmployeePrototype clone()
        {
            return new Employee(this);
        }

        public override string ToString()
        {
            return String.Format("[{0}] {1} - {2}", this.position, this.name, this.salary);
        }
    }
}