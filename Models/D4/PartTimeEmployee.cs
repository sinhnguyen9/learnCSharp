namespace MyApp.Models
{
    public class PartTimeEmployee : BaseEmployee
    {
        public double HourlyRate { get; set; } 
        public double WorkingRate { get; set; }

        public PartTimeEmployee(string id, string name, double hourlyRate, double workingRate) : base(id, name)
        {
            HourlyRate = hourlyRate;
            WorkingRate = workingRate;
        }
        public override double CalculateSalary()
        {
            return HourlyRate * WorkingRate;
        }
    }
}