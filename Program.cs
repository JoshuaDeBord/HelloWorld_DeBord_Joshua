using System;

namespace HelloWorld_DeBord_Joshua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            
            Console.WriteLine($"Hello, {firstName} {lastName}!");
            
            Console.WriteLine("How has your day been?");
            string dayBeen = Console.ReadLine();

            Console.WriteLine($"I'm happy to know that!");
        }
    }
}
