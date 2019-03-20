using H_Personel.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H_Personel.Controllers
{
    public class DepartmanController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult list()
        {
            var model = db.Departman.ToList();
            return View(model);
        }
    }
    
}