using Personel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personel.Controllers
{
    public class DepartmanController : Controller
    {
        public ActionResult Index()
        {
            //ActionResult dışardan gelen veri tiplerinin tümünü geri döndürür.(ilk örnek string tipindeydi.)
            var departman = new Departman() { id = 55, Dep_Ad = "Bilgi Teknolojileri" };
            return View(departman);
        }
    }
}