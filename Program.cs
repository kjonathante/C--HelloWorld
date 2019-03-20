using System;

namespace root
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");
            Console.WriteLine("World!");
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.Write("Good day, ");
            Console.Write(name);
            Console.WriteLine("!");        
        }
    }
}