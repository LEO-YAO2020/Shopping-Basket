using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ShopBasket.Models;

namespace ShopBasket.Data
{
    public class ShopBasketContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ShopBasketContext() : base("name=ShopBasketContext")
        {
        }

        public System.Data.Entity.DbSet<ShopBasket.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<ShopBasket.Models.Product> Products { get; set; }
        public System.Data.Entity.DbSet<ShopBasket.Models.ProductImage> ProductImages { get; set; }

        public System.Data.Entity.DbSet<ShopBasket.Models.ProductImageMapping> ProductImageMappings { get; set; }
        public DbSet<BasketLine> BasketLines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}
