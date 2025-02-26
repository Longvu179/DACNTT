using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MobiSell.Models;

namespace MobiSell.Data
{
    public class MobiSellContext : IdentityDbContext<User>
    {
        public MobiSellContext(DbContextOptions<MobiSellContext> options)
            : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Product_SKU> Product_SKUs { get; set; } = default!;
        public DbSet<Product_Image> Product_Images { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Order_Item> Order_Items { get; set; } = default!;
        public DbSet<Voucher> Vouchers { get; set; } = default!;
        public DbSet<Cart> Carts { get; set; } = default!;
        public DbSet<Cart_Item> Cart_Items { get; set; } = default!;
        public DbSet<Review> Reviews { get; set; } = default!;
        public DbSet<WishList> WishLists { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Apple", Description = "", DayCreate = DateTime.Now },
                new Brand { Id = 2, Name = "Samsung", Description = "", DayCreate = DateTime.Now },
                new Brand { Id = 3, Name = "Xiaomi", Description = "", DayCreate = DateTime.Now },
                new Brand { Id = 4, Name = "Oppo", Description = "", DayCreate = DateTime.Now },
                new Brand { Id = 5, Name = "Vivo", Description = "", DayCreate = DateTime.Now },
                new Brand { Id = 6, Name = "Huawei", Description = "", DayCreate = DateTime.Now }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Iphone 16 Pro max", Description = "", BrandId = 1, Chip = "Apple A18 Pro 6 nhân", Size = "6.9\"", 
                    LxWxHxW = "Dài 163 mm - Ngang 77.6 mm - Dày 8.25 mm - Nặng 227 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "Chính 48 MP & Phụ 48 MP, 12 MP", 
                    Battery = "33 giờ", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 2, Name = "Iphone 16 ", Description = "", BrandId = 1, Chip = "Apple A18 6 nhân", Size = "6.1\"", 
                    LxWxHxW = "Dài 147.6 mm - Ngang 71.6 mm - Dày 7.8 mm - Nặng 170 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "Chính 48 MP & Phụ 12 MP", 
                    Battery = "22 giờ", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 3, Name = "Iphone 16 Pro", Description = "", BrandId = 1, Chip = "Apple A18 Pro 6 nhân", Size = "6.3\"", 
                    LxWxHxW = "Dài 149.6 mm - Ngang 71.5 mm - Dày 8.25 mm - Nặng 199 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "Chính 48 MP & Phụ 48 MP, 12 MP", 
                    Battery = "27 giờ", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },
                
                new Product { Id = 3, Name = "Iphone 16 Plus", Description = "", BrandId = 1, Chip = "Apple A18 6 nhân", Size = "6.7\"", 
                    LxWxHxW = "Dài 160.9 mm - Ngang 77.8 mm - Dày 7.8 mm - Nặng 199 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "Chính 48 MP & Phụ 48 MP, 12 MP", 
                    Battery = "27 giờ", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 1, Name = "Iphone 15 Pro max", Description = "", BrandId = 1, Chip = "Apple A18 Pro 6 nhân", Size = "6.9\"", 
                    LxWxHxW = "Dài 163 mm - Ngang 77.6 mm - Dày 8.25 mm - Nặng 227 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "Chính 48 MP & Phụ 48 MP, 12 MP", 
                    Battery = "33 giờ", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 4, Name = "OPPO Reno13 F 5G", Description = "", BrandId = 4, Chip = "Snapdragon 6 Gen 1 5G 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 162.2 mm - Ngang 75.05 mm - Dày 7.76 mm - Nặng 192 g", Display = "AMOLED", FrontCamera = "32 MP", RearCamera = "Chính 50 MP & Phụ 8 MP, 2 MP", 
                    Battery = "5800 mAh", Charger = "45W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 5, Name = "OPPO Reno13 5G", Description = "", BrandId = 4, Chip = "MediaTek Dimensity 8350 5G 8 nhân", Size = "6.59\"", 
                    LxWxHxW = "Dài 157.9 mm - Ngang 74.73 mm - Dày 7.24 mm - Nặng 181 g", Display = "AMOLED", FrontCamera = "50 MP", RearCamera = "Chính 50 MP & Phụ 8 MP, 2 MP", 
                    Battery = "5600 mAh", Charger = "80W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 6, Name = "OPPO Reno13 Pro 5G", Description = "", BrandId = 4, Chip = "MediaTek Dimensity 8350 5G 8 nhân", Size = "6.83\"", 
                    LxWxHxW = "Dài 162.73 mm - Ngang 76.55 mm - Dày 7.55 mm - Nặng 195 g", Display = "AMOLED", FrontCamera = "50 MP", RearCamera = "Chính 50 MP & Phụ 50 MP, 8 MP", 
                    Battery = "5800 mAh", Charger = "80W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 7, Name = "Samsung Galaxy S25 5G", Description = "", BrandId = 2, Chip = "Qualcomm Snapdragon 8 Elite For Galaxy 8 nhân", Size = "6.2\"", 
                    LxWxHxW = "Dài 146.9 mm - Ngang 70.5 mm - Dày 7.2 mm - Nặng 162 g", Display = "Dynamic AMOLED 2X", FrontCamera = "12 MP", RearCamera = "Chính 50 MP & Phụ 12 MP, 10 MP", 
                    Battery = "4000 mAh", Charger = "25W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 8, Name = "Samsung Galaxy S25 Ultra 5G", Description = "", BrandId = 2, Chip = "Qualcomm Snapdragon 8 Elite For Galaxy 8 nhân", Size = "6.9\"", 
                    LxWxHxW = "Dài 162.8 mm - Ngang 77.6 mm - Dày 8.2 mm - Nặng 218 g", Display = "Dynamic AMOLED 2X", FrontCamera = "12 MP", RearCamera = "Chính 200 MP & Phụ 50 MP, 50 MP, 10 MP", 
                    Battery = "5000 mAh", Charger = "45W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 9, Name = "Samsung Galaxy S24 Ultra 5G", Description = "", BrandId = 2, Chip = "Snapdragon 8 Gen 3 for Galaxy", Size = "6.8\"", 
                    LxWxHxW = "Dài 162.3 mm - Ngang 79 mm - Dày 8.6 mm - Nặng 232 g", Display = "Dynamic AMOLED 2X", FrontCamera = "12 MP", RearCamera = "Chính 200 MP & Phụ 50 MP, 12 MP, 10 MP", 
                    Battery = "5000 mAh", Charger = "45W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 10, Name = "Xiaomi Redmi Note 14", Description = "", BrandId = 3, Chip = "MediaTek Helio G99-Ultra 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 163.25 mm - Ngang 76.55 mm - Dày 8.16 mm - Nặng 196.5 g", Display = "AMOLED", FrontCamera = "20 MP", RearCamera = "Chính 108 MP & Phụ 2 MP, 2 MP", 
                    Battery = "5500 mAh", Charger = "33W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 11, Name = "Xiaomi Redmi Note 14 Pro", Description = "", BrandId = 3, Chip = "MediaTek Helio G100-Ultra 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 162.16 mm - Ngang 74.92 mm - Dày 8.24 mm - Nặng 180 g", Display = "AMOLED", FrontCamera = "32 MP", RearCamera = "Chính 200 MP & Phụ 8 MP, 2 MP", 
                    Battery = "5500 mAh", Charger = "45W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 12, Name = "Xiaomi Redmi Note 14 Pro 5G", Description = "", BrandId = 3, Chip = "MediaTek Dimensity 7300-Ultra 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 162.33 mm - Ngang 74.42 mm - Dày 8.4 mm - Nặng 190 g", Display = "AMOLED", FrontCamera = "20 MP", RearCamera = "Chính 200 MP & Phụ 8 MP, 2 MP", 
                    Battery = "5110 mAh", Charger = "45W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 13, Name = "Vivo V29e 5G", Description = "", BrandId = 5, Chip = "Snapdragon 695 5G 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 162.35 mm - Ngang 74.85 mm - Dày 7.69 mm - Nặng 190 g", Display = "AMOLED", FrontCamera = "50 MP", RearCamera = "Chính 64 MP & Phụ 8 MP", 
                    Battery = "5000 mAh", Charger = "44W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 14, Name = "Vivo Y100 5G", Description = "", BrandId = 5, Chip = "Snapdragon 4 Gen 2 5G 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 163.17 mm - Ngang 75.81 mm - Dày 7.79 mm - Nặng 186 g", Display = "AMOLED", FrontCamera = "8 MP", RearCamera = "Chính 50 MP & Phụ 2 MP", 
                    Battery = "5000 mAh", Charger = "80W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now },

                new Product { Id = 15, Name = "Vivo Y17s", Description = "", BrandId = 5, Chip = "MediaTek Helio G85 8 nhân", Size = "6.56\"", 
                    LxWxHxW = "Dài 163.74 mm - Ngang 75.43 mm - Dày 8.09 mm - Nặng 186 g", Display = "AMOLED", FrontCamera = "8 MP", RearCamera = "Chính 50 MP & Phụ 2 MP", 
                    Battery = "5000 mAh", Charger = "15W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = DateTime.Now, DayUpdate = DateTime.Now }

            );

            modelBuilder.Entity<Product_SKU>().HasData(
                new Product_SKU { Id = 1, ProductId = 1, SKU = "sku", RAM_ROM = "64Gb", Color = "Xanh", DefaultPrice = 35000000, FinalPrice = 34999000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 2, ProductId = 1, SKU = "sku", RAM_ROM = "64Gb", Color = "Đen", DefaultPrice = 34500000, FinalPrice = 34499000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 3, ProductId = 1, SKU = "sku", RAM_ROM = "128Gb", Color = "Xanh", DefaultPrice = 41000000, FinalPrice = 40999000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 4, ProductId = 1, SKU = "sku", RAM_ROM = "128Gb", Color = "Đen", DefaultPrice = 40000000, FinalPrice = 39999000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 5, ProductId = 1, SKU = "sku", RAM_ROM = "128Gb", Color = "Trắng", DefaultPrice = 40000000, FinalPrice = 39999000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 6, ProductId = 2, SKU = "sku", RAM_ROM = "64Gb", Color = "Đen", DefaultPrice = 25000000, FinalPrice = 24999000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 7, ProductId = 2, SKU = "sku", RAM_ROM = "64Gb", Color = "Trắng", DefaultPrice = 24500000, FinalPrice = 24499000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 8, ProductId = 2, SKU = "sku", RAM_ROM = "64Gb", Color = "Xanh", DefaultPrice = 25000000, FinalPrice = 24999000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 9, ProductId = 2, SKU = "sku", RAM_ROM = "128Gb", Color = "Xanh", DefaultPrice = 28000000, FinalPrice = 27999000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 10, ProductId = 2, SKU = "sku", RAM_ROM = "128Gb", Color = "Trắng", DefaultPrice = 28000000, FinalPrice = 27999000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 11, ProductId = 3, SKU = "sku", RAM_ROM = "64Gb", Color = "Đỏ", DefaultPrice = 10000000, FinalPrice = 10000000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 12, ProductId = 3, SKU = "sku", RAM_ROM = "64Gb", Color = "Trắng", DefaultPrice = 10000000, FinalPrice = 10000000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 13, ProductId = 3, SKU = "sku", RAM_ROM = "64Gb", Color = "Xanh", DefaultPrice = 10000000, FinalPrice = 10000000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 14, ProductId = 3, SKU = "sku", RAM_ROM = "128Gb", Color = "Đỏ", DefaultPrice = 10000000, FinalPrice = 10000000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 15, ProductId = 3, SKU = "sku", RAM_ROM = "128Gb", Color = "Trắng", DefaultPrice = 10000000, FinalPrice = 10000000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 16, ProductId = 4, SKU = "sku", RAM_ROM = "64Gb", Color = "Đen", DefaultPrice = 10000000, FinalPrice = 10000000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 17, ProductId = 4, SKU = "sku", RAM_ROM = "64Gb", Color = "Xanh", DefaultPrice = 10000000, FinalPrice = 10000000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 18, ProductId = 4, SKU = "sku", RAM_ROM = "64Gb", Color = "Trắng", DefaultPrice = 10000000, FinalPrice = 10000000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 19, ProductId = 4, SKU = "sku", RAM_ROM = "128Gb", Color = "Trắng", DefaultPrice = 10000000, FinalPrice = 10000000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Product_SKU { Id = 20, ProductId = 4, SKU = "sku", RAM_ROM = "128Gb", Color = "Đen", DefaultPrice = 10000000, FinalPrice = 10000000, ImageName = "", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now }
                
            );
        }
    }
}
