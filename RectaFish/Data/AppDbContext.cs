using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RectaFish.Models;

namespace RectaFish.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }



        public DbSet<Item> Items { get; set; }
        public DbSet<Item_Sale> Items_Sales { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
    }
}
