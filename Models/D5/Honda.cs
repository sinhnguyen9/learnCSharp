using System;

namespace MyApp.Models
{
    public class Honda : Car
    {
        public Honda(string brand) : base(brand) { }
        public override void Drive()
        {
            Console.WriteLine("Honda driving...");
        }
    }
}