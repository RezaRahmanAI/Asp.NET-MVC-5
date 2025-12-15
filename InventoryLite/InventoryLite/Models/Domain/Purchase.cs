using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InventoryLite.Models.Domain
{
    public class Purchase
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Range(0, double.MaxValue)]
        public decimal UnitCost { get; set; }
        public DateTime PurchaseDate { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}