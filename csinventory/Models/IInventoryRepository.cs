using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csinventory.Models
{
    public interface IInventoryRepository
    {
        IQueryable<Part> Parts { get; }
        IQueryable<Branch> Branches { get; }

        void SavePart(Part p);
        void CreatePart(Part p);
        void DeletePart(Part p);
        void SaveBranch(Branch b);
        void CreateBranch(Branch b);
        void DeleteBranch(Branch b);
    }
}
