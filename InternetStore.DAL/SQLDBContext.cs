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
    }
}
