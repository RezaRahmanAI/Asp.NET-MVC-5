using InventoryLite.Models.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace InventoryLite.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext() : base("InventoryConnection"){ }

        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}