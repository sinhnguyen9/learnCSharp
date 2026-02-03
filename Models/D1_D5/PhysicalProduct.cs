using MyApp.Extension;
using System;

namespace MyApp.Models.D1_D5
{
    public class PhysicalProduct : Product
    {
        public double Weight { get; set; }

        public PhysicalProduct(int id, string name, double price, double weight) : base(id, price, name)
        {
            Weight = weight;
        }

        public override double LastPrice()
        {
            return Price + (Weight * 5);
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Can nang cua san pham la: {Weight} | Ship: {(Weight * 5).ToUSD()} | Tong tien: {LastPrice().ToUSD()}");
        }
    }
}