using ManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Event> Events { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}
