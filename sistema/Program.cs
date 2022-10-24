using System;

namespace MyConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"{nameof(MyConsoleApp)} {DateTime.UtcNow}");
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
comentario domingo

