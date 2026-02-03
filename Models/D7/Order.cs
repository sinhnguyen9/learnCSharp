public class Order
{
    public Order(int id, string customer, double totalAmount, string status)
    {
        Id = id;
        Customer = customer;
        TotalAmount = totalAmount;
        Status = status;
    }

    public int Id { get; set; }
    public string Customer { get; set; }
    public double TotalAmount { get; set; }
    public string Status { get; set; } // "NEW", "PAID", "CANCEL"


}
