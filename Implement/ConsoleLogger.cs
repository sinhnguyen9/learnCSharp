using MyApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Implement
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Console Logger: {message}");
        }
    }
}
