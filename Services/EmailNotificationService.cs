using MyApp.Interfaces.D1_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services
{
    internal class EmailNotificationService : INotificationService
    {
        public async Task SendNotifyAsync(string message)
        {
            Console.WriteLine($"Sending email: [{message}]");
            await Task.Delay(1000);
        }
    }
}
