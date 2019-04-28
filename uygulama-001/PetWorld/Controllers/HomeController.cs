using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetWorld.Entity;
using PetWorld.Models;

namespace PetWorld.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var urunler = db.Products
                .Where(i => i.IsApproved && i.IsHome)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                    Description = i.Description.Length > 100 ? i.Description.Substring(0, 97) + "..." : i.Description,
                    Stock = i.Stock,
                    Price = i.Price,
                    CategoryId = i.CategoryId,
                    Image = i.Image
                }).ToList();

            return View(urunler);

        }
        public ActionResult Details(int id)
        {
            return View(db.Products.Where(i => i.Id == id).ToList());
        }
        public ActionResult List(int? id)
        {
            var urunler = db.Products
                .Where(i => i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                    Description = i.Description.Length > 100 ? i.Description.Substring(0, 97) + "..." : i.Description,
                    Stock = i.Stock,
                    Price = i.Price,
                    CategoryId = i.CategoryId,
                    Image = i.Image == null ? "/holder.js/300x200" : i.Image
                }).AsQueryable();
            if (id !=null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }

            return View(urunler.ToList());
        }

        //partialView oluşturmak
        public PartialViewResult GetCategories()
        {
            return PartialView(db.Categories.ToList());
        }
    }
}