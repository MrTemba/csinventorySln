using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace csinventory.Models
{
    public class Part
    {
        public long PartID { get; set; }
        [Required(ErrorMessage = "Please enter a Part Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a Description")]
        public string Description { get; set; }
        public bool ReWorkable { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid Quantity")]
        public int Quantity { get; set; }
        [Required]
        [Range(1, long.MaxValue,
            ErrorMessage = "Please specify a Part Number")]
        public long PartNumber { get; set; }
        [Required]
        [Range(0, double.MaxValue,
            ErrorMessage = "Please enter a valid Price")]
        [Column(TypeName="decimal(8,2)")]
        public decimal UnitCost { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal TotalCost { get; set; }
    }
}
