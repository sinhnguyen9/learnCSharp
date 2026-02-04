using System.ComponentModel.DataAnnotations;

namespace MyApp.Models.D1_11
{
    internal class Ticket
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public PriorityEnum Priority { get; set; }
        public Ticket() { }
        public Ticket(string title, PriorityEnum priority)
        {
            Title = title;
            Priority = priority;
        }
        public Ticket(int id, string title, string description, DateTime createAt, PriorityEnum priority)
        {
            Id = id;
            Title = title;
            Description = description;
            CreatedAt = createAt;
            Priority = priority;
        }
    }
}
