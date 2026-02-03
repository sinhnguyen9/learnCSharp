namespace MyApp.Models
{
    public class Employee(string name, double baseSalary)
    {
        public string Name { get; set; } = name;
        public double BaseSalary { get; set; } = baseSalary;

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