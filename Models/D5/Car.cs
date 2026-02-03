using MyApp.Extension;
using MyApp.Interface;
using System;

namespace MyApp.Models
{
    public abstract class Car : IVehicle
    {
        public string Brand { get; set; } = "";

        protected Car(string brand)
        {
            Brand = brand;
        }

        public virtual void Drive()
        {
            Console.WriteLine("Car is driving...");
        }
        public void StartEngine()
        {
            Console.WriteLine($"{Brand} engine started...");
        }
    }
}