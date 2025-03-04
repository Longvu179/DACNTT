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

        public DbSet<Address> Address { get; set; } = default!;
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
                new Brand { Id = 1, Name = "Apple", Description = "", DayCreate = new DateTime(2025, 02, 25) },
                new Brand { Id = 2, Name = "Samsung", Description = "", DayCreate = new DateTime(2025, 02, 12) },
                new Brand { Id = 3, Name = "Oppo", Description = "", DayCreate = new DateTime(2025, 02, 12) },
                new Brand { Id = 4, Name = "Xiaomi", Description = "", DayCreate = new DateTime(2025, 02, 12) },
                new Brand { Id = 5, Name = "Vivo", Description = "", DayCreate = new DateTime(2025, 02, 12) },
                new Brand { Id = 6, Name = "Huawei", Description = "", DayCreate = new DateTime(2025, 02, 12) }
                );

            modelBuilder.Entity<Product>().HasData(
                //Apple
                new Product { Id = 1, Name = "Iphone 16 Pro max", Description = "", BrandId = 1, Chip = "Apple A18 Pro 6 nhân", Size = "6.9\"", 
                    LxWxHxW = "Dài 163 mm - Ngang 77.6 mm - Dày 8.25 mm - Nặng 227 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "Chính 48 MP & Phụ 48 MP, 12 MP", 
                    Battery = "33 giờ", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },
                
                new Product { Id = 2, Name = "Iphone 16 Pro", Description = "", BrandId = 1, Chip = "Apple A18 Pro 6 nhân", Size = "6.3\"", 
                    LxWxHxW = "Dài 149.6 mm - Ngang 71.5 mm - Dày 8.25 mm - Nặng 199 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "Chính 48 MP & Phụ 48 MP, 12 MP", 
                    Battery = "27 giờ", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },
                
                new Product { Id = 3, Name = "Iphone 16", Description = "", BrandId = 1, Chip = "Apple A18 6 nhân", Size = "6.1\"", 
                    LxWxHxW = "Dài 147.6 mm - Ngang 71.6 mm - Dày 7.8 mm - Nặng 170 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "Chính 48 MP & Phụ 12 MP", 
                    Battery = "22 giờ", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },
                
                new Product { Id = 4, Name = "Iphone 16 Plus", Description = "", BrandId = 1, Chip = "Apple A18 6 nhân", Size = "6.7\"", 
                    LxWxHxW = "Dài 160.9 mm - Ngang 77.8 mm - Dày 7.8 mm - Nặng 199 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "Chính 48 MP & Phụ 48 MP, 12 MP", 
                    Battery = "27 giờ", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 5, Name = "Iphone 15 Pro max", Description = "", BrandId = 1, Chip = "Apple A17 Pro 6 nhân", Size = "6.7\"", 
                    LxWxHxW = "Dài 159.9 mm - Ngang 76.7 mm - Dày 8.25 mm - Nặng 221 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "Chính 48 MP & Phụ 48 MP, 12 MP", 
                    Battery = "4422 mAh", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },
                
                new Product { Id = 6, Name = "Iphone 14 Plus", Description = "", BrandId = 1, Chip = "Apple A15 Bionic", Size = "6.7\"", 
                    LxWxHxW = "Dài 160.8 mm - Ngang 78.1 mm - Dày 7.8 mm - Nặng 203 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "2 camera 12 MP", 
                    Battery = "4325 mAh", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },
                
                new Product { Id = 7, Name = "Iphone 15", Description = "", BrandId = 1, Chip = "Apple A16 Bionic", Size = "6.1\"", 
                    LxWxHxW = "Dài 147.6 mm - Ngang 71.6 mm - Dày 7.8 mm - Nặng 171 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "Chính 48 MP & Phụ 12 MP", 
                    Battery = "3349 mAh", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },
                
                new Product { Id = 8, Name = "Iphone 14", Description = "", BrandId = 1, Chip = "Apple A15 Bionic", Size = "6.1\"", 
                    LxWxHxW = "Dài 146.7 mm - Ngang 71.5 mm - Dày 7.8 mm - Nặng 172 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "2 camera 12 MP", 
                    Battery = "3279 mAh", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },
                
                new Product { Id = 9, Name = "Iphone 13", Description = "", BrandId = 1, Chip = "Apple GPU 4 nhân ", Size = "6.1\"", 
                    LxWxHxW = "Dài 146.7 mm - Ngang 71.5 mm - Dày 7.65 mm - Nặng 173 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "2 camera 12 MP", 
                    Battery = "3240 mAh", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },
                
                new Product { Id = 10, Name = "Iphone 12", Description = "", BrandId = 1, Chip = "Apple A14 Bionic", Size = "6.1\"", 
                    LxWxHxW = "Dài 146.7 mm - Ngang 71.5 mm - Dày 7.4 mm - Nặng 164 g", Display = "OLED", FrontCamera = "12 MP", RearCamera = "2 camera 12 MP", 
                    Battery = "2815 mAh", Charger = "20W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                //Samsung
                new Product { Id = 11, Name = "Samsung Galaxy S25 5G", Description = "", BrandId = 2, Chip = "Qualcomm Snapdragon 8 Elite For Galaxy 8 nhân", Size = "6.2\"", 
                    LxWxHxW = "Dài 146.9 mm - Ngang 70.5 mm - Dày 7.2 mm - Nặng 162 g", Display = "Dynamic AMOLED 2X", FrontCamera = "12 MP", RearCamera = "Chính 50 MP & Phụ 12 MP, 10 MP", 
                    Battery = "4000 mAh", Charger = "25W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 12, Name = "Samsung Galaxy S25 Ultra 5G", Description = "", BrandId = 2, Chip = "Qualcomm Snapdragon 8 Elite For Galaxy 8 nhân", Size = "6.9\"", 
                    LxWxHxW = "Dài 162.8 mm - Ngang 77.6 mm - Dày 8.2 mm - Nặng 218 g", Display = "Dynamic AMOLED 2X", FrontCamera = "12 MP", RearCamera = "Chính 200 MP & Phụ 50 MP, 50 MP, 10 MP", 
                    Battery = "5000 mAh", Charger = "45W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 13, Name = "Samsung Galaxy S24 Ultra 5G", Description = "", BrandId = 2, Chip = "Snapdragon 8 Gen 3 for Galaxy", Size = "6.8\"",
                    LxWxHxW = "Dài 162.3 mm - Ngang 79 mm - Dày 8.6 mm - Nặng 232 g", Display = "Dynamic AMOLED 2X", FrontCamera = "12 MP", RearCamera = "Chính 200 MP & Phụ 50 MP, 12 MP, 10 MP", 
                    Battery = "5000 mAh", Charger = "45W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 14, Name = "Samsung Galaxy A16 5G", Description = "", BrandId = 2, Chip = "MediaTek Dimensity 6300 5G 8 nhân", Size = "6.7\"", 
                    LxWxHxW = "Dài 164.4 mm - Ngang 77.9 mm - Dày 7.9 mm - Nặng 192 g", Display = "Super AMOLED", FrontCamera = "13 MP", RearCamera = "Chính 50 MP & Phụ 5 MP, 2 MP", 
                    Battery = "5000 mAh", Charger = "25W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 15, Name = "Samsung Galaxy A06", Description = "", BrandId = 2, Chip = "MediaTek Helio G85", Size = "6.7\"", 
                    LxWxHxW = "Dài 167.3 mm - Ngang 77.3 mm - Dày 8 mm - Nặng 189 g", Display = "PLS LCD", FrontCamera = "8 MP", RearCamera = "Chính 50 MP & Phụ 2 MP", 
                    Battery = "5000 mAh", Charger = "25W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 16, Name = "Samsung Galaxy Z Fold6 5G", Description = "", BrandId = 2, Chip = "Snapdragon 8 Gen 3 for Galaxy", Size = "Chính 7.6\" & Phụ 6.3\"", 
                    LxWxHxW = "Dài 153.5 mm - Ngang 132.6 mm (khi mở) | 68.1 mm (khi gập) - Dày 5.6 mm (khi mở) | 12.1 mm (khi gập) - Nặng 239 g", Display = "Dynamic AMOLED 2X", 
                    FrontCamera = "10 MP & 4 MP", RearCamera = "Chính 50 MP & Phụ 12 MP, 10 MP", Battery = "4400 mAh", Charger = "25W", Accessories = "", 
                    Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 17, Name = "Samsung Galaxy A35 5G", Description = "", BrandId = 2, Chip = "Exynos 1380 8 nhân", Size = "6.6\"", 
                    LxWxHxW = "Dài 161.7 mm - Ngang 78 mm - Dày 8.2 mm - Nặng 209 g", Display = "Super AMOLED", FrontCamera = "13 MP", RearCamera = "Chính 50 MP & Phụ 8 MP, 5 MP", 
                    Battery = "5000 mAh", Charger = "25W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 18, Name = "Samsung Galaxy A25 5G", Description = "", BrandId = 2, Chip = "Exynos 1280", Size = "6.5\"", 
                    LxWxHxW = "Dài 161 mm - Ngang 76.5 mm - Dày 8.3 mm - Nặng 197 g", Display = "Super AMOLED", FrontCamera = "13 MP", RearCamera = "Chính 50 MP & Phụ 8 MP, 2 MP", 
                    Battery = "5000 mAh", Charger = "25W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 19, Name = "Samsung Galaxy S24+ 5G", Description = "", BrandId = 2, Chip = "Exynos 2400", Size = "6.7\"", 
                    LxWxHxW = "Dài 158.5 mm - Ngang 75.9 mm - Dày 7.7 mm - Nặng 196 g", Display = "Dynamic AMOLED 2X", FrontCamera = "12 MP", RearCamera = "Chính 50 MP & Phụ 12 MP, 10 MP", 
                    Battery = "4900 mAh", Charger = "45W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 20, Name = "Samsung Galaxy A55 5G", Description = "", BrandId = 2, Chip = "Exynos 1480 8 nhân", Size = "6.6\"", 
                    LxWxHxW = "Dài 161.1 mm - Ngang 77.4 mm - Dày 8.2 mm - Nặng 213 g", Display = "Super AMOLED", FrontCamera = "32 MP", RearCamera = "Chính 50 MP & Phụ 12 MP, 5 MP", 
                    Battery = "5000 mAh", Charger = "25W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 21, Name = "Samsung Galaxy M15 5G", Description = "", BrandId = 2, Chip = "MediaTek Dimensity 6100+", Size = "6.5\"", 
                    LxWxHxW = "Dài 160.1 mm - Ngang 76.8 mm - Dày 9.3 mm - Nặng 217 g", Display = "Super AMOLED", FrontCamera = "13 MP", RearCamera = "Chính 50 MP & Phụ 5 MP, 2 MP", 
                    Battery = "6000 mAh", Charger = "25W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                //Oppo
                new Product { Id = 22, Name = "OPPO Reno13 F 5G", Description = "", BrandId = 3, Chip = "Snapdragon 6 Gen 1 5G 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 162.2 mm - Ngang 75.05 mm - Dày 7.76 mm - Nặng 192 g", Display = "AMOLED", FrontCamera = "32 MP", RearCamera = "Chính 50 MP & Phụ 8 MP, 2 MP", 
                    Battery = "5800 mAh", Charger = "45W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 23, Name = "OPPO Reno13 5G", Description = "", BrandId = 3, Chip = "MediaTek Dimensity 8350 5G 8 nhân", Size = "6.59\"", 
                    LxWxHxW = "Dài 157.9 mm - Ngang 74.73 mm - Dày 7.24 mm - Nặng 181 g", Display = "AMOLED", FrontCamera = "50 MP", RearCamera = "Chính 50 MP & Phụ 8 MP, 2 MP", 
                    Battery = "5600 mAh", Charger = "80W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 24, Name = "OPPO Reno13 Pro 5G", Description = "", BrandId = 3, Chip = "MediaTek Dimensity 8350 5G 8 nhân", Size = "6.83\"", 
                    LxWxHxW = "Dài 162.73 mm - Ngang 76.55 mm - Dày 7.55 mm - Nặng 195 g", Display = "AMOLED", FrontCamera = "50 MP", RearCamera = "Chính 50 MP & Phụ 50 MP, 8 MP", 
                    Battery = "5800 mAh", Charger = "80W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 25, Name = "OPPO Reno13 F", Description = "", BrandId = 3, Chip = "MediaTek Helio G100 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 162.2 mm - Ngang 75.05 mm - Dày 7.76 mm - Nặng 192 g", Display = "AMOLED", FrontCamera = "32 MP", RearCamera = "Chính 50 MP & Phụ 8 MP, 2 MP", 
                    Battery = "5800 mAh", Charger = "45W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 26, Name = "OPPO A60", Description = "", BrandId = 3, Chip = "Snapdragon 680", Size = "6.67\"",
                    LxWxHxW = "Dài 165.71 mm - Ngang 76.02 mm - Dày 7.68 mm - Nặng 186 g", Display = "IPS LCD", FrontCamera = "8 MP", RearCamera = "Chính 50 MP & Phụ 2 MP", 
                    Battery = "5000 mAh", Charger = "45 W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 27, Name = "OPPO Reno12 F", Description = "", BrandId = 3, Chip = "Snapdragon 685 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 163.1 mm - Ngang 75.8 mm - Dày 7.69 mm - Nặng 187 g", Display = "AMOLED", FrontCamera = "32 MP", RearCamera = "Chính 50 MP & Phụ 8 MP, 2 MP", 
                    Battery = "5000 mAh", Charger = "45W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                //Xiaomi
                new Product { Id = 28, Name = "Xiaomi Redmi Note 14", Description = "", BrandId = 4, Chip = "MediaTek Helio G99-Ultra 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 163.25 mm - Ngang 76.55 mm - Dày 8.16 mm - Nặng 196.5 g", Display = "AMOLED", FrontCamera = "20 MP", RearCamera = "Chính 108 MP & Phụ 2 MP, 2 MP", 
                    Battery = "5500 mAh", Charger = "33W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 29, Name = "Xiaomi Redmi Note 14 Pro", Description = "", BrandId = 4, Chip = "MediaTek Helio G100-Ultra 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 162.16 mm - Ngang 74.92 mm - Dày 8.24 mm - Nặng 180 g", Display = "AMOLED", FrontCamera = "32 MP", RearCamera = "Chính 200 MP & Phụ 8 MP, 2 MP", 
                    Battery = "5500 mAh", Charger = "45W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 30, Name = "Xiaomi Redmi Note 14 Pro 5G", Description = "", BrandId = 4, Chip = "MediaTek Dimensity 7300-Ultra 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 162.33 mm - Ngang 74.42 mm - Dày 8.4 mm - Nặng 190 g", Display = "AMOLED", FrontCamera = "20 MP", RearCamera = "Chính 200 MP & Phụ 8 MP, 2 MP", 
                    Battery = "5110 mAh", Charger = "45W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 31, Name = "Xiaomi Redmi Note 14 Pro+ 5G", Description = "", BrandId = 4, Chip = "Snapdragon 7s Gen 3 5G 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 162.53 mm - Ngang 74.67 mm - Dày 8.75 mm - Nặng 210.14g", Display = "AMOLED", FrontCamera = "20 MP", RearCamera = "Chính 200 MP & Phụ 8 MP, 2 MP", 
                    Battery = "5110 mAh", Charger = "120 W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 32, Name = "Xiaomi Redmi 13", Description = "", BrandId = 4, Chip = "MediaTek Helio G91 Ultra 8 nhân", Size = "6.79\"", 
                    LxWxHxW = "Dài 168.6 mm - Ngang 76.28 mm - Dày 8.3 mm - Nặng 205 g", Display = "IPS LCD", FrontCamera = "13 MP", RearCamera = "Chính 108 MP & Phụ 2 MP", 
                    Battery = "5030 mAh", Charger = "33W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 33, Name = "Xiaomi Redmi 14C", Description = "", BrandId = 4, Chip = "MediaTek Helio G81-Ultra 8 nhân", Size = "6.88\"", 
                    LxWxHxW = "Dài 171.88 mm - Ngang 77.8 mm - Dày 8.22 mm - Nặng 207 g", Display = "IPS LCD", FrontCamera = "13 MP", RearCamera = "Chính 50 MP & Phụ QVGA", 
                    Battery = "5160 mAh", Charger = "18W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 34, Name = "Xiaomi 14T 5G", Description = "", BrandId = 4, Chip = "MediaTek Dimensity 8300 Ultra 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 160.5 mm - Ngang 75.1 mm - Dày 7.8 mm - Nặng 195 g", Display = "AMOLED", FrontCamera = "32 MP", RearCamera = "Chính 50 MP & Phụ 50 MP, 12 MP", 
                    Battery = "5000 mAh", Charger = "67W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                //Vivo
                new Product { Id = 35, Name = "Vivo V40 Lite", Description = "", BrandId = 5, Chip = "Snapdragon 685 8 nhân", Size = "6.67\"", 
                    LxWxHxW = "Dài 163.23 mm - Ngang 75.93 mm - Dày 7.79 mm - Nặng 188g", Display = "AMOLED", FrontCamera = "32 MP", RearCamera = "Chính 50 MP & Phụ 2 MP", 
                    Battery = "5000 mAh", Charger = "80W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 36, Name = "Vivo Y28", Description = "", BrandId = 5, Chip = "MediaTek Helio G85", Size = "6.68\"", 
                    LxWxHxW = "Dài 165.7 mm - Ngang 76 mm - Dày 7.99 mm - Nặng 199 g", Display = "IPS LCD", FrontCamera = "8 MP", RearCamera = "Chính 50 MP & Phụ 2 MP", 
                    Battery = "6000 mAh", Charger = "44W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 37, Name = "Vivo V40 5G", Description = "", BrandId = 5, Chip = "Snapdragon 7 Gen 3 8 nhân", Size = "6.78\"", 
                    LxWxHxW = "Dài 164.16 mm - Ngang 74.93 mm - Dày 7.58 mm - Nặng 190 g", Display = "AMOLED", FrontCamera = "50 MP", RearCamera = "2 camera 50 MP", 
                    Battery = "5500 mAh", Charger = "80W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 38, Name = "Vivo Y19s", Description = "", BrandId = 5, Chip = "Unisoc Tiger T612", Size = "6.68\"", 
                    LxWxHxW = "Dài 165.75 mm - Ngang 76.1 mm - Dày 8.1 mm - Nặng 198 g", Display = "IPS LCD", FrontCamera = "5 MP", RearCamera = "Chính 50 MP & Phụ 0.08 MP", 
                    Battery = "5500 mAh", Charger = "15W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) },

                new Product { Id = 39, Name = "Vivo V30e 5G", Description = "", BrandId = 5, Chip = "Snapdragon 6 Gen 1 8 nhân", Size = "6.78\"", 
                    LxWxHxW = "Dài 164.36 mm - Ngang 74.75 mm - Dày 7.75 mm - Nặng 188 g", Display = "AMOLED", FrontCamera = "32 MP", RearCamera = "Chính 50 MP & Phụ 8 MP", 
                    Battery = "5500 mAh", Charger = "44 W", Accessories = "", Quality = 10, Sold = 0, IsAvailable = true, DayCreate = new DateTime(2025, 02, 12), DayUpdate = new DateTime(2025, 02, 12) }
            );

            modelBuilder.Entity<Product_Image>().HasData(
                new Product_Image { Id = 1, ProductId = 1, ImageName = "iphone-16-pro-titan-tu-nhien.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 2, ProductId = 2, ImageName = "iphone-16-pro-titan-sa-mac.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 3, ProductId = 3, ImageName = "iphone-16-xanh-mong-ket.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 4, ProductId = 4, ImageName = "iphone-16-trang.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 5, ProductId = 5, ImageName = "iphone-15-pro-max_5.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 6, ProductId = 6, ImageName = "iphone-14-plus-tim.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 7, ProductId = 7, ImageName = "iphone-15-hong.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 8, ProductId = 8, ImageName = "iphone-14-vang.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 9, ProductId = 9, ImageName = "iphone-13-xanh.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 10, ProductId = 10, ImageName = "iphone-12-tim.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 11, ProductId = 11, ImageName = "dien-thoai-samsung-galaxy-s25_3.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 12, ProductId = 12, ImageName = "dien-thoai-samsung-galaxy-s25-ultra_1.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 13, ProductId = 13, ImageName = "ss-s24-ultra-vang-222.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 14, ProductId = 14, ImageName = "samsung-a16-5g_1.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 15, ProductId = 15, ImageName = "dien-thoai-samsung-galaxy-a06.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 16, ProductId = 16, ImageName = "samsung-galaxy-z-fold6-thumb.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 17, ProductId = 17, ImageName = "sm-a356_galaxy_a35_awesome_iceblue_ui.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 18, ProductId = 18, ImageName = "galaxy-a25-xanh-duongnhat.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 19, ProductId = 19, ImageName = "galaxy-s24-plus-vang.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 20, ProductId = 20, ImageName = "sm-a556_galaxy_a55_awesome_lilac_ui.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 21, ProductId = 21, ImageName = "ss-m15-xanhduong.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 22, ProductId = 22, ImageName = "dien-thoai-oppo-reno13-f-5g-hinh-2.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 23, ProductId = 23, ImageName = "oppo-reno13-5g-thumb.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 24, ProductId = 24, ImageName = "oppo-reno13-pro-5g-grey-thumb.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 25, ProductId = 25, ImageName = "oppo-reno13-f-thumb.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 26, ProductId = 26, ImageName = "dien-thoai-oppo-a60.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 27, ProductId = 27, ImageName = "oppo-reno-12f-cam.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 28, ProductId = 28, ImageName = "dien-thoai-xiaomi-redmi-note-14_2.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 29, ProductId = 29, ImageName = "xiaomi-redmi-note-14-pro-thumb.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 30, ProductId = 30, ImageName = "xiaomi-redmi-note-14-pro-5g-xanh-thumb.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 31, ProductId = 31, ImageName = "dien-thoai-xiaomi-redmi-note-14-pro-plus-den.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 32, ProductId = 32, ImageName = "redmi-13-blue-thumb.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 33, ProductId = 33, ImageName = "redmi_14c_xanhduong.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 34, ProductId = 34, ImageName = "xiaomi_14t_xam.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 35, ProductId = 35, ImageName = "vivo-v40lite-hong.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 36, ProductId = 36, ImageName = "vivo-y28-chinh-hang-xanh.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 37, ProductId = 37, ImageName = "vivo-v40-tim.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 38, ProductId = 38, ImageName = "dien-thoai-vivo-y19s-den.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true },
                new Product_Image { Id = 39, ProductId = 39, ImageName = "dien-thoai-vivo-v30e-nau.png", CreatedAt = new DateTime(2025, 02, 12), IsMain = true }

                );

            modelBuilder.Entity<Product_SKU>().HasData(

                // iPhone 16 Pro Max
                new Product_SKU { Id = 1, ProductId = 1, SKU = "IP16PM-128-XANH", RAM_ROM = "128GB", Color = "Titan sa mạc", DefaultPrice = 37000000, FinalPrice = 34999000, ImageName = "iphone-16-pro-titan-sa-mac.png", Quantity = 30, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 2, ProductId = 1, SKU = "IP16PM-128-TRANG", RAM_ROM = "128GB", Color = "Titan trắng", DefaultPrice = 37000000, FinalPrice = 34999000, ImageName = "iphone-16-pro-titan-trang.png", Quantity = 50, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 3, ProductId = 1, SKU = "IP16PM-128-DEN", RAM_ROM = "128GB", Color = "Titan đen", DefaultPrice = 37000000, FinalPrice = 34999000, ImageName = "iphone-16-pro-titan-den.png", Quantity = 20, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 4, ProductId = 1, SKU = "IP16PM-64-XANH", RAM_ROM = "128GB", Color = "Titan tự nhiên", DefaultPrice = 37000000, FinalPrice = 34999000, ImageName = "iphone-16-pro-titan-tu-nhien.png", Quantity = 40, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 5, ProductId = 1, SKU = "IP16PM-128-XANH", RAM_ROM = "256GB", Color = "Titan sa mạc", DefaultPrice = 40000000, FinalPrice = 37999000, ImageName = "iphone-16-pro-titan-sa-mac.png", Quantity = 30, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 6, ProductId = 1, SKU = "IP16PM-128-TRANG", RAM_ROM = "256GB", Color = "Titan trắng", DefaultPrice = 40000000, FinalPrice = 37999000, ImageName = "iphone-16-pro-titan-trang.png", Quantity = 50, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 7, ProductId = 1, SKU = "IP16PM-128-DEN", RAM_ROM = "256GB", Color = "Titan đen", DefaultPrice = 40000000, FinalPrice = 37999000, ImageName = "iphone-16-pro-titan-den.png", Quantity = 20, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 8, ProductId = 1, SKU = "IP16PM-64-XANH", RAM_ROM = "256GB", Color = "Titan tự nhiên", DefaultPrice = 40000000, FinalPrice = 37999000, ImageName = "iphone-16-pro-titan-tu-nhien.png", Quantity = 40, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 9, ProductId = 1, SKU = "IP16PM-128-XANH", RAM_ROM = "512GB", Color = "Titan sa mạc", DefaultPrice = 45000000, FinalPrice = 42999000, ImageName = "iphone-16-pro-titan-sa-mac.png", Quantity = 30, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 10, ProductId = 1, SKU = "IP16PM-128-TRANG", RAM_ROM = "512GB", Color = "Titan trắng", DefaultPrice = 45000000, FinalPrice = 42999000, ImageName = "iphone-16-pro-titan-trang.png", Quantity = 50, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 11, ProductId = 1, SKU = "IP16PM-128-DEN", RAM_ROM = "512GB", Color = "Titan đen", DefaultPrice = 45000000, FinalPrice = 42999000, ImageName = "iphone-16-pro-titan-den.png", Quantity = 20, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 12, ProductId = 1, SKU = "IP16PM-64-XANH", RAM_ROM = "512GB", Color = "Titan tự nhiên", DefaultPrice = 45000000, FinalPrice = 42999000, ImageName = "iphone-16-pro-titan-tu-nhien.png", Quantity = 40, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },

                // iPhone 16 Pro
                new Product_SKU { Id = 13, ProductId = 2, SKU = "IP16P-128-TRANG", RAM_ROM = "128GB", Color = "Titan trắng", DefaultPrice = 30000000, FinalPrice = 28999000, ImageName = "iphone-16-pro-titan-trang.png", Quantity = 60, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 14, ProductId = 2, SKU = "IP16P-256-DEN", RAM_ROM = "128GB", Color = "Titan đen", DefaultPrice = 30000000, FinalPrice = 28999000, ImageName = "iphone-16-pro-titan-den.png", Quantity = 30, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 15, ProductId = 2, SKU = "IP16P-128-TRANG", RAM_ROM = "128GB", Color = "Titan tự nhiên", DefaultPrice = 30000000, FinalPrice = 28999000, ImageName = "iphone-16-pro-titan-tu-nhien.png", Quantity = 50, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 16, ProductId = 2, SKU = "IP16P-256-XANH", RAM_ROM = "128GB", Color = "Titan sa mạc", DefaultPrice = 30000000, FinalPrice = 28999000, ImageName = "iphone-16-pro-titan-sa-mac.png", Quantity = 30, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 17, ProductId = 2, SKU = "IP16P-128-TRANG", RAM_ROM = "256GB", Color = "Titan trắng", DefaultPrice = 35000000, FinalPrice = 33499000, ImageName = "iphone-16-pro-titan-trang.png", Quantity = 60, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 18, ProductId = 2, SKU = "IP16P-256-DEN", RAM_ROM = "256GB", Color = "Titan đen", DefaultPrice = 35000000, FinalPrice = 33499000, ImageName = "iphone-16-pro-titan-den.png", Quantity = 30, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 19, ProductId = 2, SKU = "IP16P-128-TRANG", RAM_ROM = "256GB", Color = "Titan tự nhiên", DefaultPrice = 35000000, FinalPrice = 33999000, ImageName = "iphone-16-pro-titan-tu-nhien.png", Quantity = 50, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 20, ProductId = 2, SKU = "IP16P-256-XANH", RAM_ROM = "256GB", Color = "Titan sa mạc", DefaultPrice = 35000000, FinalPrice = 33999000, ImageName = "iphone-16-pro-titan-sa-mac.png", Quantity = 30, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                
                // iPhone 16
                new Product_SKU { Id = 21, ProductId = 3, SKU = "IP16P-512-DEN", RAM_ROM = "128GB", Color = "Đen", DefaultPrice = 22999000, FinalPrice = 21599000, ImageName = "iphone-16-den.png", Quantity = 20, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 22, ProductId = 3, SKU = "IP16P-512-DEN", RAM_ROM = "128GB", Color = "Trắng", DefaultPrice = 22999000, FinalPrice = 21599000, ImageName = "iphone-16-trang.png", Quantity = 30, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 23, ProductId = 3, SKU = "IP16P-512-DEN", RAM_ROM = "128GB", Color = "Hồng", DefaultPrice = 22999000, FinalPrice = 21599000, ImageName = "iphone-16-hong.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 24, ProductId = 3, SKU = "IP16P-512-DEN", RAM_ROM = "128GB", Color = "Xanh mòng két", DefaultPrice = 22999000, FinalPrice = 21999000, ImageName = "iphone-16-xanh-mong-ket.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 25, ProductId = 3, SKU = "IP16P-512-DEN", RAM_ROM = "128GB", Color = "Xanh lưu ly", DefaultPrice = 22999000, FinalPrice = 21999000, ImageName = "iphone-16-xanh-luu-ly.png", Quantity = 20, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 26, ProductId = 3, SKU = "IP16P-512-DEN", RAM_ROM = "256GB", Color = "Đen", DefaultPrice = 24999000, FinalPrice = 24999000, ImageName = "iphone-16-den.png", Quantity = 20, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 27, ProductId = 3, SKU = "IP16P-512-DEN", RAM_ROM = "256GB", Color = "Trắng", DefaultPrice = 24999000, FinalPrice = 24999000, ImageName = "iphone-16-trang.png", Quantity = 30, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 28, ProductId = 3, SKU = "IP16P-512-DEN", RAM_ROM = "256GB", Color = "Hồng", DefaultPrice = 24999000, FinalPrice = 24999000, ImageName = "iphone-16-hong.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 29, ProductId = 3, SKU = "IP16P-512-DEN", RAM_ROM = "256GB", Color = "Xanh mòng két", DefaultPrice = 24999000, FinalPrice = 24999000, ImageName = "iphone-16-xanh-mong-ket.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 30, ProductId = 3, SKU = "IP16P-512-DEN", RAM_ROM = "256GB", Color = "Xanh lưu ly", DefaultPrice = 24999000, FinalPrice = 24999000, ImageName = "iphone-16-xanh-luu-ly.png", Quantity = 20, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                
                // iPhone 16 Plus
                new Product_SKU { Id = 31, ProductId = 4, SKU = "IP16P-512-DEN", RAM_ROM = "128GB", Color = "Đen", DefaultPrice = 24999000, FinalPrice = 24999000, ImageName = "iphone-16-den.png", Quantity = 20, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 32, ProductId = 4, SKU = "IP16P-512-DEN", RAM_ROM = "128GB", Color = "Trắng", DefaultPrice = 24999000, FinalPrice = 24999000, ImageName = "iphone-16-trang.png", Quantity = 30, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 33, ProductId = 4, SKU = "IP16P-512-DEN", RAM_ROM = "128GB", Color = "Hồng", DefaultPrice = 24999000, FinalPrice = 24999000, ImageName = "iphone-16-hong.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 34, ProductId = 4, SKU = "IP16P-512-DEN", RAM_ROM = "128GB", Color = "Xanh mòng két", DefaultPrice = 24999000, FinalPrice = 24999000, ImageName = "iphone-16-xanh-mong-ket.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 35, ProductId = 4, SKU = "IP16P-512-DEN", RAM_ROM = "128GB", Color = "Xanh lưu ly", DefaultPrice = 24999000, FinalPrice = 24999000, ImageName = "iphone-16-xanh-luu-ly.png", Quantity = 20, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 36, ProductId = 4, SKU = "IP16P-512-DEN", RAM_ROM = "256GB", Color = "Đen", DefaultPrice = 27999000, FinalPrice = 27999000, ImageName = "iphone-16-den.png", Quantity = 20, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 37, ProductId = 4, SKU = "IP16P-512-DEN", RAM_ROM = "256GB", Color = "Trắng", DefaultPrice = 27999000, FinalPrice = 27999000, ImageName = "iphone-16-trang.png", Quantity = 30, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 38, ProductId = 4, SKU = "IP16P-512-DEN", RAM_ROM = "256GB", Color = "Hồng", DefaultPrice = 27999000, FinalPrice = 27999000, ImageName = "iphone-16-hong.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 39, ProductId = 4, SKU = "IP16P-512-DEN", RAM_ROM = "256GB", Color = "Xanh mòng két", DefaultPrice = 27999000, FinalPrice = 27999000, ImageName = "iphone-16-xanh-mong-ket.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 40, ProductId = 4, SKU = "IP16P-512-DEN", RAM_ROM = "256GB", Color = "Xanh lưu ly", DefaultPrice = 27999000, FinalPrice = 27999000, ImageName = "iphone-16-xanh-luu-ly.png", Quantity = 20, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },

                // iPhone 15 Pro Max
                new Product_SKU { Id = 41, ProductId = 5, SKU = "IP16PL-128-TRANG", RAM_ROM = "256GB", Color = "Titan Trắng", DefaultPrice = 29999000, FinalPrice = 27999000, ImageName = "iphone15-pro-max-512gb-titan-trang.png", Quantity = 4, Sold = 0, Default = true, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 42, ProductId = 5, SKU = "IP16PL-256-XANH", RAM_ROM = "256GB", Color = "Titan tự nhiên", DefaultPrice = 29999000, FinalPrice = 27999000, ImageName = "iphone-15-pro-max_5.png", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 43, ProductId = 5, SKU = "IP16PL-512-DEN", RAM_ROM = "256GB", Color = "Titan Đen", DefaultPrice = 29999000, FinalPrice = 27999000, ImageName = "iphone15-pro-max-512gb-titan-den.png", Quantity = 2, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 44, ProductId = 5, SKU = "IP16PL-128-TRANG", RAM_ROM = "512GB", Color = "Titan Trắng", DefaultPrice = 32999000, FinalPrice = 30999000, ImageName = "iphone15-pro-max-512gb-titan-trang.png", Quantity = 4, Sold = 0, Default = true, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 45, ProductId = 5, SKU = "IP16PL-256-XANH", RAM_ROM = "512GB", Color = "Titan tự nhiên", DefaultPrice = 32999000, FinalPrice = 30999000, ImageName = "iphone-15-pro-max_5.png", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 46, ProductId = 5, SKU = "IP16PL-512-DEN", RAM_ROM = "512GB", Color = "Titan Đen", DefaultPrice = 32999000, FinalPrice = 30999000, ImageName = "iphone15-pro-max-512gb-titan-den.png", Quantity = 2, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },

                // iPhone 14 Plus
                new Product_SKU { Id = 47, ProductId = 6, SKU = "IP15PM-128-TRANG", RAM_ROM = "128GB", Color = "Đỏ", DefaultPrice = 24999000, FinalPrice = 19999000, ImageName = "iphone-14-plus-do.png", Quantity = 5, Sold = 0, Default = true, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 48, ProductId = 6, SKU = "IP15PM-256-XANH", RAM_ROM = "128GB", Color = "Xanh", DefaultPrice = 24999000, FinalPrice = 19999000, ImageName = "iphone-14-plus-xanh.png", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 49, ProductId = 6, SKU = "IP15PM-512-DEN", RAM_ROM = "128GB", Color = "Tím", DefaultPrice = 24999000, FinalPrice = 19999000, ImageName = "iphone-14-plus-tim.png", Quantity = 0, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 50, ProductId = 6, SKU = "IP15PM-128-TRANG", RAM_ROM = "256GB", Color = "Đỏ", DefaultPrice = 27999000, FinalPrice = 21599000, ImageName = "iphone-14-plus-do.png", Quantity = 5, Sold = 0, Default = true, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 51, ProductId = 6, SKU = "IP15PM-256-XANH", RAM_ROM = "256GB", Color = "Xanh", DefaultPrice = 27999000, FinalPrice = 21599000, ImageName = "iphone-14-plus-xanh.png", Quantity = 0, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 52, ProductId = 6, SKU = "IP15PM-512-DEN", RAM_ROM = "256GB", Color = "Tím", DefaultPrice = 27999000, FinalPrice = 21799000, ImageName = "iphone-14-plus-tim.png", Quantity = 2, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },

                // iPhone 15
                new Product_SKU { Id = 53, ProductId = 7, SKU = "IP15-128-TRANG", RAM_ROM = "256GB", Color = "Hồng", DefaultPrice = 22999000, FinalPrice = 18999000, ImageName = "iphone-15-hong.png", Quantity = 5, Sold = 0, Default = true, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 54, ProductId = 7, SKU = "IP15-256-XANH", RAM_ROM = "256GB", Color = "Xanh dương", DefaultPrice = 22999000, FinalPrice = 18999000, ImageName = "iphone-15-128gb-xanh-duong.png", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 55, ProductId = 7, SKU = "IP15-512-DEN", RAM_ROM = "256GB", Color = "Xanh lá", DefaultPrice = 22999000, FinalPrice = 18999000, ImageName = "iphone-15-128gb-xanh-la.png", Quantity = 2, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 56, ProductId = 7, SKU = "IP15-128-TRANG", RAM_ROM = "512GB", Color = "Hồng", DefaultPrice = 24999000, FinalPrice = 20999000, ImageName = "iphone-15-hong.png", Quantity = 5, Sold = 0, Default = true, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 57, ProductId = 7, SKU = "IP15-256-XANH", RAM_ROM = "512GB", Color = "Xanh dương", DefaultPrice = 24999000, FinalPrice = 20999000, ImageName = "iphone-15-128gb-xanh-duong.png", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 58, ProductId = 7, SKU = "IP15-512-DEN", RAM_ROM = "512GB", Color = "Xanh lá", DefaultPrice = 24999000, FinalPrice = 20999000, ImageName = "iphone-15-128gb-xanh-la.png", Quantity = 0, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },

                // iPhone 13
                new Product_SKU { Id = 59, ProductId = 9, SKU = "IP13-128-TRANG", RAM_ROM = "128GB", Color = "Trắng", DefaultPrice = 20999000, FinalPrice = 14999000, ImageName = "iphone-13-trang.png", Quantity = 5, Sold = 0, Default = true, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 60, ProductId = 9, SKU = "IP13-256-XANH", RAM_ROM = "128GB", Color = "Xanh", DefaultPrice = 20999000, FinalPrice = 14999000, ImageName = "iphone-13-xanh.png", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 61, ProductId = 9, SKU = "IP13-512-DEN", RAM_ROM = "128GB", Color = "Đen", DefaultPrice = 20999000, FinalPrice = 14599000, ImageName = "iphone-13-den.png", Quantity = 2, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 62, ProductId = 9, SKU = "IP13-512-DEN", RAM_ROM = "128GB", Color = "Hồng", DefaultPrice = 20999000, FinalPrice = 15599000, ImageName = "iphone-13-hong.png", Quantity = 2, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 63, ProductId = 9, SKU = "IP13-128-TRANG", RAM_ROM = "256GB", Color = "Trắng", DefaultPrice = 22999000, FinalPrice = 16999000, ImageName = "iphone-13-trang.png", Quantity = 5, Sold = 0, Default = true, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 64, ProductId = 9, SKU = "IP13-256-XANH", RAM_ROM = "256GB", Color = "Xanh", DefaultPrice = 22999000, FinalPrice = 16999000, ImageName = "iphone-13-xanh.png", Quantity = 3, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 65, ProductId = 9, SKU = "IP13-512-DEN", RAM_ROM = "256GB", Color = "Đen", DefaultPrice = 22999000, FinalPrice = 16999000, ImageName = "iphone-13-den.png", Quantity = 2, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 66, ProductId = 9, SKU = "IP13-512-DEN", RAM_ROM = "256GB", Color = "Hồng", DefaultPrice = 22999000, FinalPrice = 16999000, ImageName = "iphone-13-hong.png", Quantity = 0, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },

                // Samsung galaxy s25 5G
                new Product_SKU { Id = 67, ProductId = 11, SKU = "GS-25-TRANG", RAM_ROM = "256GB", Color = "Xám", DefaultPrice = 22999000, FinalPrice = 19999000, ImageName = "dien-thoai-samsung-galaxy-s25_4.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 68, ProductId = 11, SKU = "GS-25-TRANG", RAM_ROM = "256GB", Color = "Trắng", DefaultPrice = 22999000, FinalPrice = 19999000, ImageName = "dien-thoai-samsung-galaxy-s25_3.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 69, ProductId = 11, SKU = "GS-25-TRANG", RAM_ROM = "256GB", Color = "Xanh lá", DefaultPrice = 22999000, FinalPrice = 19999000, ImageName = "dien-thoai-samsung-galaxy-s25_2.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 70, ProductId = 11, SKU = "GS-25-TRANG", RAM_ROM = "256GB", Color = "Xanh navy", DefaultPrice = 22999000, FinalPrice = 19999000, ImageName = "dien-thoai-samsung-galaxy-s25_1.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 71, ProductId = 11, SKU = "GS-25-TRANG", RAM_ROM = "512GB", Color = "Xám", DefaultPrice = 26499000, FinalPrice = 23499000, ImageName = "dien-thoai-samsung-galaxy-s25_4.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 72, ProductId = 11, SKU = "GS-25-TRANG", RAM_ROM = "512GB", Color = "Trắng", DefaultPrice = 26499000, FinalPrice = 23499000, ImageName = "dien-thoai-samsung-galaxy-s25_3.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 73, ProductId = 11, SKU = "GS-25-TRANG", RAM_ROM = "512GB", Color = "Xanh lá", DefaultPrice = 26499000, FinalPrice = 23499000, ImageName = "dien-thoai-samsung-galaxy-s25_2.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 74, ProductId = 11, SKU = "GS-25-TRANG", RAM_ROM = "512GB", Color = "Xanh navy", DefaultPrice = 26499000, FinalPrice = 23499000, ImageName = "dien-thoai-samsung-galaxy-s25_1.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },

                // SS galaxy s25 ultra 
                new Product_SKU { Id = 75, ProductId = 12, SKU = "GS-S25U-TRANG", RAM_ROM = "256GB", Color = "Trắng", DefaultPrice = 33999000, FinalPrice = 30999000, ImageName = "dien-thoai-samsung-galaxy-s25-ultra.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 76, ProductId = 12, SKU = "GS-S25U-TRANG", RAM_ROM = "256GB", Color = "Xanh", DefaultPrice = 33999000, FinalPrice = 30999000, ImageName = "dien-thoai-samsung-galaxy-s25-ultra_2.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 77, ProductId = 12, SKU = "GS-S25U-TRANG", RAM_ROM = "256GB", Color = "Xám", DefaultPrice = 33999000, FinalPrice = 30999000, ImageName = "dien-thoai-samsung-galaxy-s25-ultra_1.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 78, ProductId = 12, SKU = "GS-S25U-TRANG", RAM_ROM = "256GB", Color = "Đen", DefaultPrice = 33999000, FinalPrice = 30999000, ImageName = "dien-thoai-samsung-galaxy-s25-ultra_3.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 79, ProductId = 12, SKU = "GS-S25U-TRANG", RAM_ROM = "512GB", Color = "Trắng", DefaultPrice = 37499000, FinalPrice = 34499000, ImageName = "dien-thoai-samsung-galaxy-s25-ultra.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 80, ProductId = 12, SKU = "GS-S25U-TRANG", RAM_ROM = "512GB", Color = "Xanh", DefaultPrice = 37499000, FinalPrice = 34499000, ImageName = "dien-thoai-samsung-galaxy-s25-ultra_2.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 81, ProductId = 12, SKU = "GS-S25U-TRANG", RAM_ROM = "512GB", Color = "Xám", DefaultPrice = 37499000, FinalPrice = 34499000, ImageName = "dien-thoai-samsung-galaxy-s25-ultra_1.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 82, ProductId = 12, SKU = "GS-S25U-TRANG", RAM_ROM = "512GB", Color = "Đen", DefaultPrice = 37499000, FinalPrice = 34499000, ImageName = "dien-thoai-samsung-galaxy-s25-ultra_3.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                
                //Zfold6
                new Product_SKU { Id = 83, ProductId = 16, SKU = "ZFOLD6-TRANG", RAM_ROM = "256GB", Color = "Xám", DefaultPrice = 43999000, FinalPrice = 38999000, ImageName = "zfold-6-xam.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 84, ProductId = 16, SKU = "ZFOLD6-TRANG", RAM_ROM = "256GB", Color = "Hồng", DefaultPrice = 43999000, FinalPrice = 38999000, ImageName = "zfold-6-hong.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 85, ProductId = 16, SKU = "ZFOLD6-TRANG", RAM_ROM = "256GB", Color = "Xanh", DefaultPrice = 43999000, FinalPrice = 38999000, ImageName = "zfold-6-xanh.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 86, ProductId = 16, SKU = "ZFOLD6-TRANG", RAM_ROM = "512GB", Color = "Xám", DefaultPrice = 47999000, FinalPrice = 41999000, ImageName = "zfold-6-xam.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 87, ProductId = 16, SKU = "ZFOLD6-TRANG", RAM_ROM = "512GB", Color = "Hồng", DefaultPrice = 47999000, FinalPrice = 41999000, ImageName = "zfold-6-hong.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 88, ProductId = 16, SKU = "ZFOLD6-TRANG", RAM_ROM = "512GB", Color = "Xanh", DefaultPrice = 47999000, FinalPrice = 41999000, ImageName = "zfold-6-xanh.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },

                // Reno 13F
                new Product_SKU { Id = 89, ProductId = 22, SKU = "RENO-13F-TRANG", RAM_ROM = "256GB", Color = "Tím", DefaultPrice = 10999000, FinalPrice = 9999000, ImageName = "dien-thoai-oppo-reno13-f-5g-hinh-2.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 90, ProductId = 22, SKU = "RENO-13F-TRANG", RAM_ROM = "256GB", Color = "Xám", DefaultPrice = 10999000, FinalPrice = 9999000, ImageName = "dien-thoai-oppo-reno13-f-5g-hinh-1.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 91, ProductId = 22, SKU = "RENO-13F-TRANG", RAM_ROM = "512GB", Color = "Tím", DefaultPrice = 11999000, FinalPrice = 11999000, ImageName = "dien-thoai-oppo-reno13-f-5g-hinh-2.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 92, ProductId = 22, SKU = "RENO-13F-TRANG", RAM_ROM = "512GB", Color = "Xám", DefaultPrice = 11999000, FinalPrice = 11999000, ImageName = "dien-thoai-oppo-reno13-f-5g-hinh-1.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },

                // Oppo A60
                new Product_SKU { Id = 93, ProductId = 26, SKU = "OPPO-A60-XANH", RAM_ROM = "128GB", Color = "Xanh", DefaultPrice = 5499000, FinalPrice = 5499000, ImageName = "dien-thoai-oppo-a60.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 94, ProductId = 26, SKU = "OPPO-A60-XANH", RAM_ROM = "128GB", Color = "Tím", DefaultPrice = 5499000, FinalPrice = 5499000, ImageName = "dien-thoai-oppo-a60_1.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 95, ProductId = 26, SKU = "OPPO-A60-XANH", RAM_ROM = "256GB", Color = "Xanh", DefaultPrice = 6499000, FinalPrice = 6099000, ImageName = "dien-thoai-oppo-a60.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 96, ProductId = 26, SKU = "OPPO-A60-XANH", RAM_ROM = "256GB", Color = "Tím", DefaultPrice = 6499000, FinalPrice = 6099000, ImageName = "dien-thoai-oppo-a60_1.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                
                // Oppo reno 12F
                new Product_SKU { Id = 97, ProductId = 27, SKU = "OPPO-12F-XANH", RAM_ROM = "256GB", Color = "Xanh", DefaultPrice = 8999000, FinalPrice = 8099000, ImageName = "oppo-reno-12f-xanh.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 98, ProductId = 27, SKU = "OPPO-12F-XANH", RAM_ROM = "256GB", Color = "Cam", DefaultPrice = 8999000, FinalPrice = 8099000, ImageName = "oppo-reno-12f-cam.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                
                // Redmi note 14
                new Product_SKU { Id = 99, ProductId = 28, SKU = "REDMI-NOTE-14", RAM_ROM = "128GB", Color = "Đen", DefaultPrice = 5699000, FinalPrice = 5699000, ImageName = "dien-thoai-xiaomi-redmi-note-14.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 100, ProductId = 28, SKU = "REDMI-NOTE-14", RAM_ROM = "128GB", Color = "Xanh", DefaultPrice = 5699000, FinalPrice = 5699000, ImageName = "dien-thoai-xiaomi-redmi-note-14_2.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 101, ProductId = 28, SKU = "REDMI-NOTE-14", RAM_ROM = "128GB", Color = "Tím", DefaultPrice = 5699000, FinalPrice = 5699000, ImageName = "dien-thoai-xiaomi-redmi-note-14_3.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 102, ProductId = 28, SKU = "REDMI-NOTE-14", RAM_ROM = "256GB", Color = "Đen", DefaultPrice = 6299000, FinalPrice = 6299000, ImageName = "dien-thoai-xiaomi-redmi-note-14.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 103, ProductId = 28, SKU = "REDMI-NOTE-14", RAM_ROM = "256GB", Color = "Xanh", DefaultPrice = 6299000, FinalPrice = 6299000, ImageName = "dien-thoai-xiaomi-redmi-note-14_2.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 104, ProductId = 28, SKU = "REDMI-NOTE-14", RAM_ROM = "256GB", Color = "Tím", DefaultPrice = 6299000, FinalPrice = 6299000, ImageName = "dien-thoai-xiaomi-redmi-note-14_3.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                
                // Redmi note 14 pro+
                new Product_SKU { Id = 105, ProductId = 31, SKU = "REDMI-NOTE-14PRO+", RAM_ROM = "256GB", Color = "Tím", DefaultPrice = 10999000, FinalPrice = 10699000, ImageName = "dien-thoai-xiaomi-redmi-note-14-pro-plus-tim.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 106, ProductId = 31, SKU = "REDMI-NOTE-14PRO+", RAM_ROM = "256GB", Color = "Đen", DefaultPrice = 10999000, FinalPrice = 10699000, ImageName = "dien-thoai-xiaomi-redmi-note-14-pro-plus-den.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 107, ProductId = 31, SKU = "REDMI-NOTE-14PRO+", RAM_ROM = "256GB", Color = "Xanh", DefaultPrice = 10999000, FinalPrice = 10699000, ImageName = "dien-thoai-xiaomi-redmi-note-14-pro-plus-xanh.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                
                // Xiaomi 14T 5G
                new Product_SKU { Id = 108, ProductId = 34, SKU = "REDMI-NOTE-14PRO+", RAM_ROM = "256GB", Color = "Đen", DefaultPrice = 12999000, FinalPrice = 11699000, ImageName = "xiaomi_14t-den.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 109, ProductId = 34, SKU = "REDMI-NOTE-14PRO+", RAM_ROM = "256GB", Color = "Xam", DefaultPrice = 12999000, FinalPrice = 11699000, ImageName = "xiaomi_14t-xam.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 110, ProductId = 34, SKU = "REDMI-NOTE-14PRO+", RAM_ROM = "256GB", Color = "Xanh", DefaultPrice = 12999000, FinalPrice = 11699000, ImageName = "xiaomi_14t-xanh.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 111, ProductId = 34, SKU = "REDMI-NOTE-14PRO+", RAM_ROM = "512GB", Color = "Đen", DefaultPrice = 13999000, FinalPrice = 12599000, ImageName = "xiaomi_14t-den.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 112, ProductId = 34, SKU = "REDMI-NOTE-14PRO+", RAM_ROM = "512GB", Color = "Xam", DefaultPrice = 13999000, FinalPrice = 12599000, ImageName = "xiaomi_14t-xam.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 113, ProductId = 34, SKU = "REDMI-NOTE-14PRO+", RAM_ROM = "512GB", Color = "Xanh", DefaultPrice = 13999000, FinalPrice = 12599000, ImageName = "xiaomi_14t-xanh.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                
                //Redmi 14C
                new Product_SKU { Id = 114, ProductId = 33, SKU = "REDMI-14C", RAM_ROM = "4/128GB", Color = "Xanh dương", DefaultPrice = 3499000, FinalPrice = 3099000, ImageName = "redmi_14c_xanhduong.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 115, ProductId = 33, SKU = "REDMI-14C", RAM_ROM = "4/128GB", Color = "Xanh lá", DefaultPrice = 3499000, FinalPrice = 3099000, ImageName = "redmi_14c_xanhla.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 116, ProductId = 33, SKU = "REDMI-14C", RAM_ROM = "4/128GB", Color = "Đen", DefaultPrice = 3499000, FinalPrice = 2999000, ImageName = "redmi_14c_den.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 117, ProductId = 33, SKU = "REDMI-14C", RAM_ROM = "6/128GB", Color = "Xanh dương", DefaultPrice = 3999000, FinalPrice = 3599000, ImageName = "redmi_14c_xanhduong.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 118, ProductId = 33, SKU = "REDMI-14C", RAM_ROM = "6/128GB", Color = "Xanh lá", DefaultPrice = 3999000, FinalPrice = 3599000, ImageName = "redmi_14c_xanhla.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 119, ProductId = 33, SKU = "REDMI-14C", RAM_ROM = "6/128GB", Color = "Đen", DefaultPrice = 3999000, FinalPrice = 3499000, ImageName = "redmi_14c_den.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                
                //Vivo v40 lite
                new Product_SKU { Id = 120, ProductId = 35, SKU = "VIVO-V40-LITE", RAM_ROM = "256GB", Color = "Xám", DefaultPrice = 8499000, FinalPrice = 8499000, ImageName = "vivo-v40lite-xam.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 121, ProductId = 35, SKU = "VIVO-V40-LITE", RAM_ROM = "256GB", Color = "Tím", DefaultPrice = 8499000, FinalPrice = 8499000, ImageName = "vivo-v40lite-tim.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 122, ProductId = 35, SKU = "VIVO-V40-LITE", RAM_ROM = "256GB", Color = "Hồng", DefaultPrice = 8499000, FinalPrice = 8499000, ImageName = "vivo-v40lite-hong.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                
                //Vivo y28
                new Product_SKU { Id = 123, ProductId = 36, SKU = "VIVO-Y28", RAM_ROM = "128GB", Color = "Cam", DefaultPrice = 5899000, FinalPrice = 5599000, ImageName = "vivo-y28-chinh-hang-cam.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 124, ProductId = 36, SKU = "VIVO-Y28", RAM_ROM = "128GB", Color = "Xanh", DefaultPrice = 5899000, FinalPrice = 5599000, ImageName = "vivo-y28-chinh-hang-xanh.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 125, ProductId = 36, SKU = "VIVO-Y28", RAM_ROM = "256GB", Color = "Cam", DefaultPrice = 6499000, FinalPrice = 6299000, ImageName = "vivo-y28-chinh-hang-cam.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 126, ProductId = 36, SKU = "VIVO-Y28", RAM_ROM = "256GB", Color = "Xanh", DefaultPrice = 6499000, FinalPrice = 6299000, ImageName = "vivo-y28-chinh-hang-xanh.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                
                //Vivo V40 5g
                new Product_SKU { Id = 127, ProductId = 37, SKU = "VIVO-V40", RAM_ROM = "256GB", Color = "Xanh", DefaultPrice = 12999000, FinalPrice = 12599000, ImageName = "vivo-v40-xanh.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 128, ProductId = 37, SKU = "VIVO-V40", RAM_ROM = "256GB", Color = "Xám", DefaultPrice = 12999000, FinalPrice = 12599000, ImageName = "vivo-v40-xam.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 129, ProductId = 37, SKU = "VIVO-V40", RAM_ROM = "256GB", Color = "Tím", DefaultPrice = 12999000, FinalPrice = 12599000, ImageName = "vivo-v40-tim.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 130, ProductId = 37, SKU = "VIVO-V40", RAM_ROM = "512GB", Color = "Xanh", DefaultPrice = 13499000, FinalPrice = 12999000, ImageName = "vivo-v40-xanh.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 131, ProductId = 37, SKU = "VIVO-V40", RAM_ROM = "512GB", Color = "Xám", DefaultPrice = 13499000, FinalPrice = 12999000, ImageName = "vivo-v40-xam.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 132, ProductId = 37, SKU = "VIVO-V40", RAM_ROM = "512GB", Color = "Tím", DefaultPrice = 13499000, FinalPrice = 12999000, ImageName = "vivo-v40-tim.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                
                //Vivo y19s
                new Product_SKU { Id = 133, ProductId = 38, SKU = "VIVO-Y19S", RAM_ROM = "6/128GB", Color = "Đen", DefaultPrice = 4499000, FinalPrice = 4499000, ImageName = "dien-thoai-vivo-y19s-den.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 134, ProductId = 38, SKU = "VIVO-Y19S", RAM_ROM = "6/128GB", Color = "Xanh", DefaultPrice = 4499000, FinalPrice = 4499000, ImageName = "dien-thoai-vivo-y19s-xanh.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 135, ProductId = 38, SKU = "VIVO-Y19S", RAM_ROM = "6/128GB", Color = "Trắng", DefaultPrice = 4499000, FinalPrice = 4499000, ImageName = "dien-thoai-vivo-y19s-trang.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 136, ProductId = 38, SKU = "VIVO-Y19S", RAM_ROM = "8/128GB", Color = "Đen", DefaultPrice = 4899000, FinalPrice = 4799000, ImageName = "dien-thoai-vivo-y19s-den.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 137, ProductId = 38, SKU = "VIVO-Y19S", RAM_ROM = "8/128GB", Color = "Xanh", DefaultPrice = 4899000, FinalPrice = 4799000, ImageName = "dien-thoai-vivo-y19s-xanh.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 138, ProductId = 38, SKU = "VIVO-Y19S", RAM_ROM = "8/128GB", Color = "Trắng", DefaultPrice = 4899000, FinalPrice = 4799000, ImageName = "dien-thoai-vivo-y19s-trang.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                
                //Vivo v30e
                new Product_SKU { Id = 139, ProductId = 39, SKU = "VIVO-V30E", RAM_ROM = "8/256GB", Color = "Trắng", DefaultPrice = 9499000, FinalPrice = 9499000, ImageName = "dien-thoai-vivo-v30e-trang.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 140, ProductId = 39, SKU = "VIVO-V30E", RAM_ROM = "8/256GB", Color = "Nâu", DefaultPrice = 9499000, FinalPrice = 9499000, ImageName = "dien-thoai-vivo-v30e-nau.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 141, ProductId = 39, SKU = "VIVO-V30E", RAM_ROM = "12/256GB", Color = "Trắng", DefaultPrice = 10499000, FinalPrice = 10199000, ImageName = "dien-thoai-vivo-v30e-trang.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) },
                new Product_SKU { Id = 142, ProductId = 39, SKU = "VIVO-V30E", RAM_ROM = "12/256GB", Color = "Nâu", DefaultPrice = 10499000, FinalPrice = 10199000, ImageName = "dien-thoai-vivo-v30e-nau.png", Quantity = 25, Sold = 0, Default = false, IsAvailable = true, CreatedAt = new DateTime(2025, 02, 12), LastUpdatedAt = new DateTime(2025, 02, 12) }

                );
        }
    }
}
