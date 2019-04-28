using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetWorld.Entity;
namespace PetWorld.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Products.Where(i=>i.IsApproved && i.IsHome).ToList());  // 
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult List()
        {
            return View(db.Products.Where(i=>i.IsApproved).FirstOrDefault());
        }
    }
}