using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewdaBirdenFazlaModel.Models;
using ViewdaBirdenFazlaModel.ViewModels;

namespace ViewdaBirdenFazlaModel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var departman = new Departman() {Dep_id=41,Dep_Ad="Mühendisler Odası" };
            var personeller = new List<Personel>()
            {
                new Personel(){Per_Ad="Personel1"},
                new Personel(){Per_Ad="Personel2"},
                new Personel(){Per_Ad="Personel3"},
                new Personel(){Per_Ad="Personel4"},
                new Personel(){Per_Ad="Personel5"}
            };
            var model = new DepartmanPersonelViewModels()
            {
                Departman=departman,
                Personeller=personeller
            };

            return View(model);
        }
    }
}