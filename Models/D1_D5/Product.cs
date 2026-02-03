namespace MyApp.Models.D1_D5
{
    public abstract class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }

        public Product(int id, double price, string name)
        {
            Id = id;
            Price = price;
            Name = name;
        }

        public abstract double LastPrice();

        public virtual void ShowInfo() { }
    }
}