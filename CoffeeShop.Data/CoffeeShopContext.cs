using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Data.Maps;
using CoffeeShop.Domain.Models;

namespace CoffeeShop.Data
{
    public class CoffeeShopContext : DbContext
    {
        public CoffeeShopContext() : base("CoffeeShop")
        {
            Database.SetInitializer(new CoffeeShopInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new ItemMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
