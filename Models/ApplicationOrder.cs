using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStoreInventory.Models
{
    [Table("Orders")]
    public class ApplicationOrder
    {
        [Key]
        public int Id { get; set; }

        //public virtual ICollection<ApplicationOrderItem> OrderItems { get; set; }

        public ApplicationOrder(int id = 0)
        {
            Id = id;
        }

        public ApplicationOrder() { }
    }
}
