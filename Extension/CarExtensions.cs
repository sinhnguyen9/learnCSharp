using MyApp.Models;

namespace MyApp.Extension
{
    public static class CarExtensions
    {
        public static void PrintInfo(this Car car)
        {
            Console.WriteLine($"🚗 Brand: {car.Brand}");
        }
    }
}