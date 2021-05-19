using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csinventory.Models
{
    public interface IInventoryRepository
    {
        IQueryable<Part> Parts { get; }

        void SavePart(Part p);
        void CreatePart(Part p);
        void DeletePart(Part p);
    }
}
