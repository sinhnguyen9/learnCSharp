namespace MyApp.Models.D7
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, double price, string category)
        {
            ID = id;
            Name = name;
            Price = price;
            Category = category;
        }
    }
}