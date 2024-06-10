using InternetPoint.Models;
using Microsoft.EntityFrameworkCore;

public class UserDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }

    public DbSet<ServiceInfo> Services { get; set; }


    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
