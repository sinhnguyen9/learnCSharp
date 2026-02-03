namespace MyApp.Models
{
    public class Cat : Pet
    {
        public string Name { get; }

        public Cat(string name) : base(name)
        {
            Name = name;
        }

        public override string MakeNoise()
        {
            return "meow";
        }
    }
}