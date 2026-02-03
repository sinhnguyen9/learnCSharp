namespace MyApp.Models.D1_D5
{
    public class DigitalProduct : Product
    {
        public string ActiveCode { get; set; } = "";

        public DigitalProduct(int id, string name, double price, string activeCode) : base(id, price, name)
        {
            ActiveCode = activeCode;
        }

        public override double LastPrice()
        {
            return Price;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Active code cua ban la: {ActiveCode}");
        }
    }
}