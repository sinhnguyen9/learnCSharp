namespace MyApp.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public Employee(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public double CalculateTax()
        {
            return BaseSalary * 0.1;
        }

        public double GetNetSalary()
        {
            return BaseSalary - CalculateTax();
        }
    }
}