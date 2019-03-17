using ActionResultt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultt.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Jsondata()
        {
            //örnek Json veri
            var dataJson = new data() { ActionResult_Ad= "JsonResult",Acıklama= "Özellikle Ajav ve Javascript işlemlerinde kullanacağımız verilerimizi json olarak döndüren Result türüdür.",Metod_Ad= "Json" };
            return Json(dataJson, JsonRequestBehavior.AllowGet);
        }

        public ContentResult Contentdata()
        {
            return Content("Content result");
        }

        public HttpNotFoundResult Resultdata()
        {
            return HttpNotFound();
        }
    }
}