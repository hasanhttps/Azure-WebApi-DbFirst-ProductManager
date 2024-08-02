using Microsoft.EntityFrameworkCore;
using Azure_ProductManagment.Entities.Concretes;

namespace Azure_ProductManagment;

public class EStoreDbContext : DbContext {

    // Constructor

    public EStoreDbContext(DbContextOptions<EStoreDbContext> options) : base(options) { }


    // Methods

    protected override void OnModelCreating(ModelBuilder modelBuilder) {

        modelBuilder.Entity<Category>()
            .ToTable("Category");

        modelBuilder.Entity<Product>()
            .ToTable("Product");

        modelBuilder.Entity<ProductImage>()
            .ToTable("ProductImages");

        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);

        modelBuilder.Entity<ProductImage>()
            .HasOne(pi => pi.Product)
            .WithMany(p => p.ProductImages)
            .HasForeignKey(pi => pi.ProductId);
    }

    // Tables

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }

}