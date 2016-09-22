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

        public virtual ApplicationProduct Product { get; set; }

        public virtual ApplicationOrder Order { get; set; }

        public ApplicationOrderItem(ApplicationProduct productId, ApplicationOrder orderId, int id = 0)
        {
            Product = productId;
            Order = orderId;
            Id = id;
        }

        public ApplicationOrderItem() { }
    }
}