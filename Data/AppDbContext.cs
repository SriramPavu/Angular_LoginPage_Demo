using LoginPageDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginPageDemo.Data
{
    public class AppDbContext : DbContext
    {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            public DbSet<User> Users { get; set; } = null!;
            public DbSet<GridItem> GridItems { get; set; } = null!;
    }
}
