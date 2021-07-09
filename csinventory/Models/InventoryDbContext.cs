using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace csinventory.Models
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
        : base(options) { }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Branch> Branches { get; set; }
    }
}
