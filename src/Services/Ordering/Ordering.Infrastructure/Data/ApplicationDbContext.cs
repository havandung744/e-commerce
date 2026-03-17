using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Models;

namespace Ordering.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Customer> Customers => Set<Customer>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Order>(entity =>
            //{
            //    entity.HasKey(e => e.Id);
            //    entity.OwnsOne(e => e.ShippingAddress);
            //    entity.OwnsOne(e => e.BillingAddress);
            //    entity.OwnsOne(e => e.Payment);
            //});
            //modelBuilder.Entity<OrderItem>(entity =>
            //{
            //    entity.HasKey(e => e.Id);
            //    entity.HasOne<Order>()
            //        .WithMany(o => o.OrderItems)
            //        .HasForeignKey(oi => oi.OrderId)
            //        .OnDelete(DeleteBehavior.Cascade);
            //});
            //modelBuilder.Entity<Product>(entity =>
            //{
            //    entity.HasKey(e => e.Id);
            //});
            //modelBuilder.Entity<Customer>(entity =>
            //{
            //    entity.HasKey(e => e.Id);
            //});
        }
    }
}
