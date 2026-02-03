namespace MyApp.Models
{
    public class PartTimeEmployee(string id, string name, double hourlyRate, double workingRate) : BaseEmployee(id, name)
    {
        public double HourlyRate { get; set; } = hourlyRate;
        public double WorkingRate { get; set; } = workingRate;
        public override double CalculateSalary()
        {
            return HourlyRate * WorkingRate;
        }
    }
}