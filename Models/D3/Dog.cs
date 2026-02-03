namespace MyApp.Models
{
    public class Dog: Pet
    {
        public string Name { get; }

        public Dog(string name): base(name)
        {
            Name = name;
        }
        public override string MakeNoise() => "bark";

    }
}