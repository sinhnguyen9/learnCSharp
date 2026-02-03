namespace MyApp.Models
{
    public class Cat(string name) : Pet(name)
    {
        public override string MakeNoise()
        {
            return "meow";
        }
    }
}