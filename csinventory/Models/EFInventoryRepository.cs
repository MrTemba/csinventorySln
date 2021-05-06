using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csinventory.Models
{
    public class EFInventoryRepository : IInventoryRepository
    {
        private InventoryDbContext context;
        public EFInventoryRepository(InventoryDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Part> Parts => context.Parts;
    }
}