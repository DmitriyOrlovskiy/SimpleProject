using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Now is {DateTime.Now}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
