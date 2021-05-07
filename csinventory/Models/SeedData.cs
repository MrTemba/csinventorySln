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
                    Name = "Epp USB",
                    Description = "EPP USB",
                    Quantity = 18,
                    PartNumber = 4450745408,
                    UnitCost = 0,
                    TotalCost = 0
                }, new Part
                {
                    Name = "Pick Module",
                    Description = "PICK MODULE(S1)",
                    Quantity = 70,
                    PartNumber = 4450728164,
                    UnitCost = 0,
                    TotalCost = 0
                }, new Part
                {
                    Name = "Escrow & Reservoir",
                    Description = "ESCROW & RESERVOIR NARROW",
                    Quantity = 2,
                    PartNumber = 90033246,
                    UnitCost = 0,
                    TotalCost = 0
                });
                context.SaveChanges();
            }
        }
    }
}
