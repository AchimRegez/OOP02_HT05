using System;

namespace Aufgabe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting App..");

            Console.WriteLine("Your input:");

            while (true)
            {
                string input = Console.ReadLine();

                if (input != "exit")
                {
                    Console.WriteLine("task canceled");
                }
                else
                {
                    Console.WriteLine("The programme has been ended!");
                    break;
                }
            }
        }
    }
}
