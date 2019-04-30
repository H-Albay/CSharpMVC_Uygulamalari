using Etkinlik_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Etkinlik_WebApi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DavetiyeForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DavetiyeForm(DavetiyeModel model)
        {
            if (ModelState.IsValid == true)
            {
                Veritabani.Add(model);
                return View("Thanks", model);
            }
            return View(model);
        }

        [ChildActionOnly] //URLden Katilanlar görmeyi engelledik.
        public ActionResult Katilanlar()
        {
            var data = Veritabani.Liste.Where(i => i.KatilmaDurumu == true);
            return PartialView(data);
        }
    }
}