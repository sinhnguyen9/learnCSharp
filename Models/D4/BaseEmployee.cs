namespace MyApp.Models
{
    public abstract class BaseEmployee
    {
        public string Id { get; } = "";
        public string Name { get; } = "";

        protected BaseEmployee() { }

        protected BaseEmployee(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract double CalculateSalary();
    }
}