namespace MyApp.Models.D8
{
    public class OrderNoLinq
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public double Amount { get; set; }

        public OrderNoLinq(int id, string customer, double amount)
        {
            Id = id;
            Customer = customer;
            Amount = amount;
        }
    }
}
