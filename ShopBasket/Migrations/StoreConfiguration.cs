using System.Collections.Generic;
using ShopBasket.Models;

namespace ShopBasket.Migrations.StoreConfiguration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class StoreConfiguration : DbMigrationsConfiguration<ShopBasket.Data.ShopBasketContext>
    {
        public StoreConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopBasket.Data.ShopBasketContext context)
        {

            var categories = new List<Category>
            {
                new Category {Name = "Computers and Tablets" },
                new Category {Name = "PC Peripherals" },
                new Category {Name = "PC Parts" },
                new Category {Name = "Networking" },
                new Category {Name = "Printing and Office" },
                new Category {Name = "Software and Games" },
                new Category {Name = "TV Video and Audio" },
                new Category {Name = "Cameras and Drones" },
                new Category {Name = "Toys and More" },
                new Category {Name = "Apple"}
             };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product {Name = "HP ProOne 400 G5 Business All in One", Description = "All in One FHD Intel i7 9700T 16GB 256GB",Features = "Easy to deploy, sleek, and feature-rich, the HP ProOne 400 20, All-in-One PC features a contemporary design with business-class performance, collaboration, security, and manageability features.", Price = 1631, CategoryID= categories.Single(c=>c.Name == "Computers and Tablets").ID},

                new Product {Name = "LG UltraGear 27GL850B 27", Description = "IPS 2K Gaming Monitor",Features = "QHD Monitor , Nano IPS , 2560X1440 , 1ms , 144Hz , G-Sync Compatible , High Adjustable", Price = 898, CategoryID= categories.Single(c=>c.Name == "PC Peripherals").ID},

                new Product {Name = "Titan Army N27QW 27", Description = "Curved QHD Gaming Monitor",Features = "Curved for your Viewing Pleasure/Fast like an eSports Superstar/AMD FreeSync for Smooth Graphics/Engineered for a Superior Visual Experience", Price = 369, CategoryID= categories.Single(c=>c.Name == "PC Peripherals").ID},

                new Product {Name = "EVGA GeForce", Description = "EVGA GeForce RTX 3060 Ti 8GB DDR6",Features = "NVIDIA AMPERE ARCHITECTURE/EVGA GeForce RTX 3060 Ti FTW3/iCX3 INTERACTIVE COOLING/ADD YOUR OWN PERSONAL FLAIR", Price = 1000, CategoryID= categories.Single(c=>c.Name == "PC Parts").ID},

                new Product {Name = "Orico Nano USB Bluetooth", Description = "4 Adapter Driver Free With Windows 10",Features = "ORICO BTA-402 Bluetooth 4.0 USB Micro Adapter Dongle Achieved with CSR8510 Class 2 Low Energy Controller fully Content with Bluetooth 4.0 Specification.24-Bit CRC Verification & Adaptive Frequency Hopping(AFH)", Price = 76, CategoryID= categories.Single(c=>c.Name == "Networking").ID},

                new Product {Name = "Microsoft Home 10", Description = "64 bit Microsoft Home 10",Features = "The best Windows ever keeps getting better/An experience you know and more to love/Sign in fast, secure, and password-free", Price = 217, CategoryID= categories.Single(c=>c.Name == "Software and Games").ID},

                new Product {Name = "Microsoft XBox One X", Description = "1 TB Microsoft XBox One X",Features = "TRUE 4K Gaming/UP TO 120 Frames per second/8K HDR High Dynamic Range/Xbox Velocity Architecture", Price = 749, CategoryID= categories.Single(c=>c.Name == "TV Video and Audio").ID},

                new Product {Name = "TP Link NC 450", Description = "HD Pan Tilt Wifi Camera",Features = "Boost Your Wi-Fi Coverage Up to 10,000 sq ft*/Super-Fast Speed Next Generation AC Wi-Fi/Gigabit Wired Speed", Price = 163.31M, CategoryID= categories.Single(c=>c.Name == "Cameras and Drones").ID},

            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order { DeliveryAddress = new Address { AddressLine1="49 Juniper Road", Town="SunnyNook", Country="NewZealand", PostCode="0436" }, TotalPrice=631, UserID="admin@example.com", DateCreated=new DateTime(2021, 1, 1) , DeliveryName="Admin" },
                new Order { DeliveryAddress = new Address { AddressLine1="12 Widdison Place", Town="Albany", Country="NewZealand", PostCode="0632" }, TotalPrice=239, UserID="admin@example.com", DateCreated=new DateTime(2021, 1, 2) , DeliveryName="Admin" },
                new Order { DeliveryAddress = new Address { AddressLine1="49 Juniper Road", Town="SunnyNook", Country="NewZealand", PostCode="0436" }, TotalPrice=631, UserID="admin@example.com", DateCreated=new DateTime(2021, 1, 6) , DeliveryName="Admin" },
                new Order { DeliveryAddress = new Address { AddressLine1="12 Widdison Place", Town="Albany", Country="NewZealand", PostCode="0632" }, TotalPrice=239, UserID="admin@example.com", DateCreated=new DateTime(2021, 1, 12) , DeliveryName="Admin" },
                new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street", Town="Town1", Country="Country", PostCode="PostCode" }, TotalPrice=19.49M, UserID="admin@example.com", DateCreated=new DateTime(2020, 1, 15) , DeliveryName="Admin" }
            };

            orders.ForEach(c => context.Orders.AddOrUpdate(o => o.DateCreated, c));
            context.SaveChanges();

            var orderLines = new List<OrderLine>
            {
                new OrderLine { OrderID = 1, ProductID = products.Single( c=> c.Name == "Microsoft Home 10").ID, ProductName ="Microsoft Home 10", Quantity =1, UnitPrice=products.Single( c=> c.Name == "Microsoft Home 10").Price },

                new OrderLine { OrderID = 2, ProductID = products.Single( c=> c.Name == "LG UltraGear 27GL850B 27").ID, ProductName="LG UltraGear 27GL850B 27", Quantity=1, UnitPrice=products.Single( c=> c.Name =="LG UltraGear 27GL850B 27").Price },

                new OrderLine { OrderID = 3, ProductID = products.Single( c=> c.Name == "TP Link NC 450").ID, ProductName ="TP Link NC 450", Quantity=1, UnitPrice=products.Single( c=> c.Name == "TP Link NC 450").Price },

                new OrderLine { OrderID = 4, ProductID = products.Single( c=> c.Name == "Microsoft XBox One X").ID, ProductName ="Microsoft XBox One X", Quantity=1, UnitPrice=products.Single( c=> c.Name == "Microsoft XBox One X").Price },

                new OrderLine { OrderID = 5, ProductID = products.Single( c=> c.Name == "EVGA GeForce").ID, ProductName ="EVGA GeForce", Quantity=1, UnitPrice=products.Single(c=> c.Name == "EVGA GeForce").Price }
            };

            orderLines.ForEach(c => context.OrderLines.AddOrUpdate(ol => ol.OrderID, c));
            context.SaveChanges();
        }
    }
}
