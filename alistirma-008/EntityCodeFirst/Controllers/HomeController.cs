

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


        DataContext context = new DataContext();



        List<urun> urunler = new List<urun>
        {
            new urun(){UrunAdi="Bardak",StokAdeti=99,Fiyat=30},
            new urun(){UrunAdi="Kalem",StokAdeti=19,Fiyat=20},
            new urun(){UrunAdi="Silgi",StokAdeti=9,Fiyat=10}
        };
          
        public ActionResult Index()
        {
            foreach (var urun in urunler)
            {
                context.urunler.Add(urun);
            }
            context.SaveChanges();

            return View();
        }
    }
}