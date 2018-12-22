using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShop
{
    public class OnlineShopContext:DbContext
    {
        public OnlineShopContext():base("OnlineShopContext")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}