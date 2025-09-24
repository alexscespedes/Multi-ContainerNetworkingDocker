using System;
using Microsoft.EntityFrameworkCore;

namespace ProductsAPI;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Keyboard", Description = "Mechanical keyboard", Price = 79.99M, InStock = true },
            new Product { Id = 2, Name = "Mouse", Description = "Wireless mouse", Price = 29.99M, InStock = true }
        );
    }
}
