using System;
using System.Linq;

namespace Aufgabe05
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var personHans = new Person() { FirstName = "Hans", LastName = "Nötig", City = "Cham"}
            }
        }
    }
}
