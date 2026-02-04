using MyApp.Interfaces.D1_11;
using MyApp.Models.D1_11;

namespace MyApp.Services
{
    internal class TicketManager
    {
        private readonly IRepository<Ticket> _repo;
        private readonly INotificationService _notifier;
        //private MemoryRepository memoryRepository;
        //private EmailNotificationService emailNotificationService;

        public TicketManager(IRepository<Ticket> repo, INotificationService notifier)
        {
            _repo = repo;
            _notifier = notifier;
        }

        //public TicketManager(MemoryRepository memoryRepository, EmailNotificationService emailNotificationService)
        //{
        //    this.memoryRepository = memoryRepository;
        //    this.emailNotificationService = emailNotificationService;
        //}

        public async Task CreateTicketAsync(string title, PriorityEnum priority)
        {
            var ticket = new Ticket(title, priority);
            await _repo.AddAsync(ticket);
            await _notifier.SendNotifyAsync($"New ticket created: {title} with priority {priority}");
        }

        public void ShowStatistics()
        {
            var allTickets = _repo.GetAll();
            var totalTickets = allTickets.Count();
            Console.WriteLine($"Total Tickets: {totalTickets}");
            var highPriorityTickets = allTickets.Where(t => t.Priority == PriorityEnum.High).ToList();
            Console.WriteLine($"High Priority Tickets: {highPriorityTickets.Count}");
            var mediumPriorityTickets = allTickets.Where(t => t.Priority == PriorityEnum.Medium).ToList();
            Console.WriteLine($"Medium Priority Tickets: {mediumPriorityTickets.Count}");
            var lowPriorityTickets = allTickets.Where(t => t.Priority == PriorityEnum.Low).ToList();
            Console.WriteLine($"Low Priority Tickets: {lowPriorityTickets.Count}");
            var lastestTicket = allTickets.OrderByDescending(t => t.CreatedAt).FirstOrDefault();
            Console.WriteLine($"Latest Ticket: {lastestTicket?.Title} created at {lastestTicket?.CreatedAt}");
            var sumaryTicket = allTickets
                .GroupBy(t => t.Priority)
                .Select(g => new
                {
                    Priority = g.Key,
                    Count = g.Count()
                }).ToList();

            foreach (var item in sumaryTicket)
            {
                Console.WriteLine($"Ticket Summary by Priority: {item.Priority} - {item.Count}");
            }
        }
    }
}
