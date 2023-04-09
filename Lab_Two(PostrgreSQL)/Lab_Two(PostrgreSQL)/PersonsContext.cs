using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Two_PostrgreSQL_
{
    public class PersonsContext : DbContext
    {
        public DbSet<Person> Persons { get; set; } = null!;
        public PersonsContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;port=5432;Database=Persons;Username=postgres;Password=000000");
        }

    }
}
