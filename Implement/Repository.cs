using MyApp.Interface;

namespace MyApp.Implement
{
    public class Repository : IRepository
    {
        public void SqlRepository()
        {
            Console.WriteLine("Repository");
        }
    }
}
