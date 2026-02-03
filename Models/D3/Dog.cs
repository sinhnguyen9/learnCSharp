namespace MyApp.Models
{
    public class Dog(string name) : Pet(name)
    {
        public override string MakeNoise() => "bark";

    }
}