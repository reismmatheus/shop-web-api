using Microsoft.EntityFrameworkCore;
using ShopWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Infra.Data.Context
{
    public class ShopWebContext : DbContext
    {
        public ShopWebContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
