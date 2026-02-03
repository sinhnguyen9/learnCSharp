using System;

namespace MyApp.Models.D6
{
    public class Box<T>
    {
        public T BoxName { get; set; }
        public Box(T boxName)
        {
            BoxName = boxName;
        }

        public void Show()
        {
            Console.WriteLine($"{BoxName}");
        }
    }
}