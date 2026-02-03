namespace MyApp.Models
{
    public class FullTimeEmployee : BaseEmployee
    {
        private double BaseSalary { get; set; } = 0d;

        public FullTimeEmployee() { }
        public FullTimeEmployee(string id, string name, double baseSalary) : base(id, name)
        {
            BaseSalary = baseSalary;
        }

        public override double CalculateSalary()
        {
            return BaseSalary;
        }
    }
}