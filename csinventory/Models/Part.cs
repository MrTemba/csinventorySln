using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace csinventory.Models
{
    public class Part
    {
        public long PartID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ReWorkable { get; set; }
        public int Quantity { get; set; }
        public long PartNumber { get; set; }
        [Column(TypeName="decimal(8,2)")]
        public decimal UnitCost { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal TotalCost { get; set; }
    }
}
