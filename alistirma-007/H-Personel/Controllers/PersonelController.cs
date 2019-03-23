using H_Personel.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace H_Personel.Controllers
{
    public class PersonelController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();
        // GET: Personel
        public ActionResult list()
        {
            var model = db.Personel.Include(x=>x.Departman).ToList();  //burada farklı bir kullanım var lazy loading ve Eager loading joinleme işlemleri ile tek bir sorgu gönderiyorum sql tarafına.
            return View(model);
        }
    }
}