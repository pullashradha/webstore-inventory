using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStoreInventory.Models
{
    [Table("Inventory")]
    public class ApplicationProductItem
    {
        [Key]
        public int Id { get; set; }

        public bool Sold { get; set; }

        public virtual ApplicationProduct Product { get; set; }

        public virtual ApplicationOrderItem OrderItem { get; set; }

        public ApplicationProductItem(ApplicationProduct product, ApplicationOrderItem orderItem, bool sold = false)
        {
            Product = product;
            OrderItem = orderItem;
            Sold = sold;
        }

        public ApplicationProductItem() { }
    }
}
