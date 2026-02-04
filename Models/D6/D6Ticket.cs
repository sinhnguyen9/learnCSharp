public class D6Ticket
{
    public int ID { get; set; }
    public string Name { get; set; } = "";

    public D6Ticket() { }

    public D6Ticket(int id, string name)
    {
        ID = id;
        Name = name;
    }
}