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
    }
}
