namespace MyApp.Models.D8
{
    public class OrderLinq
    {
        public string Customer;
        public double Amount;
        public DateTime Date;

        public OrderLinq(string customer, double amount, DateTime date)
        {
            Customer = customer;
            Amount = amount;
            Date = date;
        }
    }
}
