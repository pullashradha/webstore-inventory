using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStoreInventory.Models
{
    [Table("Products")]
    public class ApplicationProduct
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public ApplicationProduct(string name, int quantity, int price, int id = 0)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Id = id;
        }

        public ApplicationProduct() { }
    }
}
