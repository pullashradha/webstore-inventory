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
        public int InitialQuantity { get; set; }
        public int Price { get; set; }

        public ApplicationProduct(string name, int initialQuantity, int price, int id = 0)
        {
            Name = name;
            InitialQuantity = initialQuantity;
            Price = price;
            Id = id;
        }

        public ApplicationProduct() { }
    }
}
