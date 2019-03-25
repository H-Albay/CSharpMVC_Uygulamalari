

using EntityCodeFirst.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityCodeFirst.Controllers
{
    public class HomeController : Controller
    {


        DataContext db = new DataContext();

        //list<kategori> kategoriler = new list<kategori>()
        //{
        //    new kategori(){ıd=1,kategoriadi="telefon"},
        //    new kategori(){ıd=2,kategoriadi="bilgisayar"},
        //    new kategori(){ıd=3,kategoriadi="tablet"}
        //};


        
        public ActionResult Index()
        {
            kategori k = new kategori();
            k.KategoriAdi = "Beyaz Eşya";
            db.kategoriler.Add(k);
            db.SaveChanges();
            return View();
        }
    }
}