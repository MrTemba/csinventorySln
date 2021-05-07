using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csinventory.Models.ViewModels
{
    public class PartsListViewModel
    {
        public IEnumerable<Part> Parts { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
