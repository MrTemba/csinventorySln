using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace csinventory.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            InventoryDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<InventoryDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Parts.Any())
            {
                context.Parts.AddRange(
                new Part
                {
                    Name = "Test",
                    Description = "This is a sample Part",
                    Quantity = 1,
                    PartNumber = 0000,
                    UnitCost = 0,
                    TotalCost = 0
                });
                context.SaveChanges();
            }
        }
    }
}
