using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class User:Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        List<Item> Items { get; set; }
    }
}