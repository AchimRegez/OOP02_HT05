using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe05
{
    public class Context : DbContext
    {
        public Context() : base("OOP02_HT05_Aufgabe05")
        {
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
