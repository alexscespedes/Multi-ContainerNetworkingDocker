using System;
using Microsoft.EntityFrameworkCore;

namespace OrdersAPI;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Order>().HasData(
            new Order { Id = 1, CustomerName = "Alex", Amount = 100, CreatedAt = DateTime.Today, Status = "Pending" },
            new Order { Id = 2, CustomerName = "Damon", Amount = 75, CreatedAt = DateTime.Today, Status = "Completed" },
            new Order { Id = 3, CustomerName = "Stefan", Amount = 65, CreatedAt = DateTime.Today, Status = "Not processed" }
        );
    }
}
