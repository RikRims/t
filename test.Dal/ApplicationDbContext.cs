using test.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace test.Dal
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Coment> Coments { get; set; }
        public DbSet<Order> Order { get; set; }

    }
}
