using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreInventory.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
