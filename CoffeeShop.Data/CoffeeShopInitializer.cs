using System;
using System.Collections.Generic;
using System.Data.Entity;
using CoffeeShop.Domain.Models;

namespace CoffeeShop.Data
{
    class CoffeeShopInitializer : DropCreateDatabaseIfModelChanges<CoffeeShopContext>
    {
        protected override void Seed(CoffeeShopContext context)
        {
            User user = new User()
            {
                Id = 1,
                FirstName = "Bobby",
                LastName = "Tables",
                Email = "btables@droptable.com",
                Password = "P4$$word"
            };
            context.Users.Add(user);

            context.Items.AddRange
            (
                new List<Item>
                {
                    new Item()
                    {
                        Id = 1,
                        Name = "Veranda Blend",
                        Quantity = 1000,
                        Price = 5,
                        Users = new List<User>(){user}
                    },
                    new Item()
                    {
                        Id = 2,
                        Name = "Breakfast Blend",
                        Quantity = 1000,
                        Price = 5,
                        Users = new List<User>()
                    },
                    new Item()
                    {
                        Id = 3,
                        Name = "Pike Place Roast",
                        Quantity = 1000,
                        Price = 5,
                        Users = new List<User>()
                    },
                    new Item()
                    {
                        Id = 4,
                        Name = "House Blend",
                        Quantity = 1000,
                        Price = 5,
                        Users = new List<User>()
                    },
                    new Item()
                    {
                        Id = 5,
                        Name = "Sumatra",
                        Quantity = 1000,
                        Price = 5,
                        Users = new List<User>()
                    },
                    new Item()
                    {
                        Id = 6,
                        Name = "French Roast",
                        Quantity = 1000,
                        Price = 5,
                        Users = new List<User>()
                    },
                }
            );
            context.SaveChanges();

            base.Seed(context);
        }
    }
}