using System;
using System.Threading.Tasks;

namespace Aufgabe01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            decimal number = Convert.ToDecimal(Console.ReadLine());
            CalculateGaussAsyn(number);


            Console.WriteLine("Tell me something");
            
            while (true)
            {                
                string input = Console.ReadLine();

                if (input != "exit")
                {
                    Console.WriteLine("\"{0}\", ah really!", input);
                }
                else
                {
                    Console.WriteLine("The programme has been ended!");
                    break;
                }                
            }
        }

        public async static void CalculateGaussAsyn(decimal n)
        {
            decimal ergebnis = (n * (n + 1)) / 2;
            await Task.Delay(10000);
            Console.WriteLine("Gauss Sum of {0} = {1}", n, ergebnis); ;
        }
    }
}
