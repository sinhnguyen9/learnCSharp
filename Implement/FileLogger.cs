using MyApp.Interface;

namespace MyApp.Implement
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"File Logger: {message}");
        }
    }
}
