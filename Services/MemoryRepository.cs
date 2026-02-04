using MyApp.Interfaces.D1_11;
using MyApp.Models.D1_11;

namespace MyApp.Services
{
    internal class MemoryRepository : IRepository<Ticket>
    {
        private Dictionary<int, Ticket> storage = new();
        private readonly object _locker = new object();
        private int _lastId = 0;
        public async Task AddAsync(Ticket item)
        {
            await Task.Delay(500);
            lock (_locker) {
                _lastId++;
                item.Id = _lastId;
                storage.Add(_lastId, item);
                Console.WriteLine($"Ticket with ID {item.Id} added.");
            }
        }

        public IEnumerable<Ticket> GetAll()
        {
           return storage.Values.ToList();
        }

        public Ticket? GetById(int id)
        {
            return storage.ContainsKey(id) ? storage[id] : null;
        }
    }
}
