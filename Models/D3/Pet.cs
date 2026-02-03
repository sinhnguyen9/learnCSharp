namespace MyApp.Models
{
    public abstract class Pet
    {
        public string FirstName { get; set; }
        public Pet(string firstname) {
            FirstName = firstname;
        }
        public abstract string MakeNoise();
    }
}