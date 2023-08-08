using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AzureWebApp.NetCore.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var persons = new List<Person> {
             new Person {
             Id = 1,
             FirstName = "John",
             LastName = "Parkar",
             DateOfBirth = new DateTime(1984,10,15)
             }
            };

           modelBuilder.Entity<Person>().HasData(persons);
        }
    }
}
