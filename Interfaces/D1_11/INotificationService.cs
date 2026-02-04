using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Interfaces.D1_11
{
    internal interface INotificationService
    {
        Task SendNotifyAsync(string message);
    }
}
