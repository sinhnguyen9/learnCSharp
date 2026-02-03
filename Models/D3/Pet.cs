namespace MyApp.Models
{
    public abstract class Pet(string firstname)
    {
        public string FirstName { get; set; } = firstname;
        public abstract string MakeNoise();
    }
}