using InternetStore.Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternetStore.DAL
{
    public class SQLDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        //public SQLDBContext()
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=relationsdb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasOne(u => u.Cart)
                .WithOne(p => p.User)
                .HasForeignKey<Cart>(p => p.UserId);

            modelBuilder
                .Entity<Cart>()
                .HasOne(u => u.User)
                .WithOne(c => c.Cart)
                .HasForeignKey<User>(c => c.CartId);

            //modelBuilder
            //    .Entity<Cart>()
            //    .HasMany(p => p.Products)
            //    .WithOne(c => c.Cart)
            //    .HasForeignKey<User>(c => c.CartId);

            // как вязать корзину с продуктами? продукт как сущность должен быть независим, а привязывая его к конкретной корзине получается борода

            modelBuilder
                .Entity<Product>()
                .HasMany(pp => pp.ProductPrices)
                .WithOne(p => p.Product);

            modelBuilder
                .Entity<ProductPrice>()
                .HasOne(p => p.Product)
                .WithMany(pp => pp.ProductPrices);

        }
    }
}
