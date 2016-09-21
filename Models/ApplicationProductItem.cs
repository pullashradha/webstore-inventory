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

        public ApplicationProductItem(bool sold, ApplicationProduct product, int id = 0)
        {
            Sold = sold;
            Product = product;
            Id = id;
        }

        public ApplicationProductItem() { }
    }
}
