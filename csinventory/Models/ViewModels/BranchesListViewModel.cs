using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csinventory.Models.ViewModels
{
    public class BranchesListViewModel
    {
        public IEnumerable<Branch> Branches { get; set; }
    }
}
