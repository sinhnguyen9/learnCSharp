namespace MyApp.Models.D8
{
    public class OrderD8
    {
        public OrderD8(int id, string customerName, double totalAmount, string status)
        {
            Id = id;
            CustomerName = customerName;
            TotalAmount = totalAmount;
            Status = status;
        }

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public double TotalAmount { get; set; }
        public string Status { get; set; }
    }
}
