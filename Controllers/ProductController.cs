using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreInventory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebStoreInventory.ViewModels;

namespace WebStoreInventory.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<ApplicationProduct> productsList = _db.Products.ToList();
            return View(productsList);
        }

        public IActionResult Cart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddToCart(int productId)
        {
            var productItem = _db.Inventory.FirstOrDefault(pi => pi.Sold == false && pi.Product.Id == productId);
            var newOrder = new ApplicationOrder();
            _db.Orders.Add(newOrder);

            var orderItem = new ApplicationOrderItem { Product = productItem.Product, Order = newOrder};
            productItem.OrderItem = orderItem;

            _db.OrderItems.Add(orderItem);
            _db.Entry(productItem).State = EntityState.Modified;
            _db.SaveChanges();
            var viewModel = new ProductViewModel { Name = productItem.Product.Name, InitialQuantity = productItem.Product.InitialQuantity, Price = productItem.Product.Price };
            return View(viewModel);
        }
    }
}
