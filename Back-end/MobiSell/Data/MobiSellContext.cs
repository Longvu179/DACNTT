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
    }
}
