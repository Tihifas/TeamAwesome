using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AwesomeShop.Models
{
    public class AwesomeContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}