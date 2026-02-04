using System;
using System.Collections.Generic;

namespace MyApp.Models.D6
{
    public class TicketCounter
    {
        private Queue<D6Ticket> _queue = new();
        private Dictionary<int, string> _history = new();

        public void CheckIn(D6Ticket t)
        {
            _queue.Enqueue(t);
        }

        public void Process()
        {
            if (_queue.Count == 0) return;
            var ticket = _queue.Dequeue();
            _history[ticket.ID] = $"Đã xử lý xong lúc {DateTime.Now}";
        }

        public void FindHistory(int id)
        {
            if (_history.TryGetValue(id, out var status))
                Console.WriteLine(status);
            else
                Console.WriteLine("Chưa xử lý");
        }
    }
}