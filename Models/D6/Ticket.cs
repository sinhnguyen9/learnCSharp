public class Ticket
{
    public int ID { get; set; }
    public string Name { get; set; } = "";

    public Ticket() { }

    public Ticket(int id, string name)
    {
        ID = id;
        Name = name;
    }
}