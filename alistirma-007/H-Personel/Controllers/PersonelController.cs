using H_Personel.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H_Personel.Controllers
{
    public class PersonelController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();
        // GET: Personel
        public ActionResult list()
        {
            var model = db.Personel.ToList();
            return View(model);
        }
    }
}