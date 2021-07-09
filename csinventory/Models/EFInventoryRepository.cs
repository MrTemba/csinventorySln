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

        public IQueryable<Branch> Branches => context.Branches;

        public void CreatePart(Part p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeletePart(Part p)
        {
            context.Remove(p);
            context.SaveChanges();
        }

        public void SavePart(Part p)
        {
            context.SaveChanges();
        }

        public void CreateBranch(Branch b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBranch(Branch b)
        {
            context.Remove(b);
            context.SaveChanges();
        }

        public void SaveBranch(Branch b)
        {
            context.SaveChanges();
        }
    }
}