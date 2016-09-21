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
        public IActionResult BuyProduct(int productId)
        {
            var productItem = _db.Inventory.FirstOrDefault(pi => pi.Sold == false && pi.Product.Id == productId);

            var orderItem = new ApplicationOrderItem();
            productItem.OrderItem = orderItem;

            _db.OrderItems.Add(orderItem);
            _db.Entry(productItem).State = EntityState.Modified;
            _db.SaveChanges();

            return View("Cart");
        }
    }
}
