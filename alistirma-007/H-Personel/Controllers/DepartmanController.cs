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
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(/*string Ad*/ Departman departman)
        {
            /* 1.ekleme yöntemi fakat çok sayıda değişken eklendiği durumda sıkıntı yaratabilir 
             * bu yüzden object veri tanımlanmalı (2.yöntem)
             * var departman = new Departman();
             departman.Ad = Ad;
             db.Departman.Add(departman);
            int result= db.SaveChanges();    */

            db.Departman.Add(departman);
            db.SaveChanges();

            return RedirectToAction("list","Departman");
        }

    }

}