using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShopApplication.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data
{
    public class MarketContext : DbContext
    {
        private readonly IConfiguration _config;

        public DbSet<Product> Products { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<History> Histories { get; set; }

        public MarketContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("Market"));
        }

    }
}
