using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Two
{
    class PeopleContext : DbContext
    {
        public PeopleContext() : base("MyConnectionStrings")
        {

        }
        public DbSet<Person> Persons {get; set;}
    }
}
