using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe05
{
    
    public class DbAccess
    {
        public void AddPerson()
        {
            //Add Persons to the Database
            Context.Person.Add(personHans);
            Context.Person.Add(personSabrina);
            Context.Person.Add(personAnna);
            Context.Person.Add(personStefan);
        }

        public void GetPersons()
        {
            var persons = from person in Person
                          orderby person.FirstName
                          select person;

            foreach (var person in persons)
                Console.WriteLine("");
        }

        public void AddAddress()
        {

        }

        public void GetAddresses()
        {
            var addresses = from address in Address
                            orderby address.

            foreach(Address address in addresses)
            {
                Console.WriteLine(address.ToString());
            }
        }



    }
}
