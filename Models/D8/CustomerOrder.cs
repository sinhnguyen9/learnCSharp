namespace MyApp.Models.D8
{
    public class CustomerOrder
    {
        public CustomerOrder(int id, string customerName, double amount, bool isPaid)
        {
            Id = id;
            CustomerName = customerName;
            Amount = amount;
            IsPaid = isPaid;
        }

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public double Amount { get; set; }
        public bool IsPaid { get; set; }
    }
}
