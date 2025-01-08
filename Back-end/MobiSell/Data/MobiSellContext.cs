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
        public MobiSellContext (DbContextOptions<MobiSellContext> options)
            : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Product_Image> Product_Images { get; set; } = default!;
        public DbSet<Product_Detail> Product_Details { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Order_Item> Order_Items { get; set; } = default!;
        public DbSet<Voucher> Vouchers { get; set; } = default!;
        public DbSet<Cart> Carts { get; set; } = default!;
        public DbSet<Cart_Item> Cart_Items { get; set; } = default!;
        public DbSet<Review> Reviews { get; set; } = default!;
        public DbSet<WishList> WishLists { get; set; } = default!;

    }
}
