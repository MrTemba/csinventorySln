using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace csinventory.Models
{
    public class Branch
    {
        public long BranchID { get; set; }
        [Required(ErrorMessage = "Please enter a Branch Name")]
        public string BranchName { get; set; }
        [Required(ErrorMessage = "Please enter a Branch Address")]
        public string BranchAddress { get; set; }
        [Required(ErrorMessage = "Please enter a Branch Manager")]
        public string BranchManager { get; set; }
    }
}
