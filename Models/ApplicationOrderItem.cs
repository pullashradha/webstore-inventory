using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStoreInventory.Models
{
    [Table("OrderItems")]
    public class ApplicationOrderItem
    {
        [Key]
        public int Id { get; set; }

        //public List<ApplicationProductItem> ProductItems { get; set; }

        public virtual ApplicationProduct Product { get; set; }

        public virtual ApplicationOrder Order { get; set; }

        public ApplicationOrderItem(ApplicationProduct product, int id = 0)
        {
            Product = product;
            Id = id;
        }

        public ApplicationOrderItem() { }
    }
}