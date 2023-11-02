using Microsoft.EntityFrameworkCore;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DataAccess.Concrete.Context
{
    public class ShopContext : DbContext
    {
        // Veritabanı bağlantı ayarlarını yapılandırır.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Shop;Integrated Security=True");
        }

        // Veritabanı modeli için ilişkileri ve sütun yapılandırmalarını belirtir.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Product tablosundaki UnitPrice sütununu belirli bir formatla tanımlar.
            modelBuilder.Entity<Product>()
                .Property(p => p.UnitPrice)
                .HasColumnType("decimal(18, 2)");

            // OrderDetail tablosunun anahtarını belirler (OrderId ve ProductId).
            modelBuilder.Entity<OrderDetail>()
                .HasKey(od => new { od.OrderId, od.ProductId });

            // Order tablosundaki Freight sütununu belirli bir formatla tanımlar.
            modelBuilder.Entity<Order>()
                .Property(o => o.Freight)
                .HasColumnType("decimal(18, 2)");

            // OrderDetail tablosundaki UnitPrice sütununu belirli bir formatla tanımlar.
            modelBuilder.Entity<OrderDetail>()
                .Property(od => od.UnitPrice)
                .HasColumnType("decimal(18, 2)");
        }

        // Veritabanı tabloları için DbSet tanımlamaları.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Mold> Molds { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
