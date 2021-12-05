using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace QLCoffee.Models
{
    public partial class QLCoffeeDbContext : DbContext

    {
        public QLCoffeeDbContext() : base("name=QLCoffeeDbContext")
        {
        }
        public System.Data.Entity.DbSet<QLCoffee.Models.Bills> Bills { get; set; }

        public System.Data.Entity.DbSet<QLCoffee.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<QLCoffee.Models.Employment> Employments { get; set; }

        public System.Data.Entity.DbSet<QLCoffee.Models.Inventory> Inventories { get; set; }

        public System.Data.Entity.DbSet<QLCoffee.Models.Price> Prices { get; set; }

        public System.Data.Entity.DbSet<QLCoffee.Models.Supplier> Suppliers { get; set; } 
        
        public System.Data.Entity.DbSet<QLCoffee.Models.Account> Accounts { get; set; } 


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Employment>()
           .Property(e => e.EmploymentName)
           .IsUnicode(false);

            modelBuilder.Entity<Customer>()
            .Property(e => e.CustomerName)
           .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
            .Property(e => e.SupplierName)
            .IsUnicode(false);

            modelBuilder.Entity<Inventory>()
            .Property(e => e.CoffeeID)
            .IsUnicode(false);

            modelBuilder.Entity<Account>()
            .Property(e => e.UserName)
            .IsUnicode(false);

        }

       
    }
}