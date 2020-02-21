using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "abigail";
            const string sexyName = "trace";
            const string sillyName = "kristina";
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the same name as me!");
                break;
                case sexyName:
                    Console.WriteLine("My, What a SEXY NAME YOU HAVE!");
                break;
                case sillyName:
                    Console.WriteLine("Thats a very silly and ugly name like you!");
                break;
                default:
                    Console.WriteLine("Your name is weird, I have never heard it before.");
                break;
            }
            Console.WriteLine("Hello {0}!", name);
            Console.ReadKey();


        }
    }
}
