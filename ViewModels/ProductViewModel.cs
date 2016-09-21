using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreInventory.ViewModels
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public int InitialQuantity { get; set; }
        public int Price { get; set; }
    }
}
