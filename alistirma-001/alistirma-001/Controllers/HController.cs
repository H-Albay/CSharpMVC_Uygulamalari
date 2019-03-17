using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace alistirma_001.Controllers
{
    public class HController : Controller
    {
        /*
        // başlangıçtaki index metodunu şimdilik görmezden geleyim.
        public ActionResult Index()
        {
            return View();
        }   */

        // Bu şekilde çalıştırırsam merhaba metotumu başlagıçta görmeyecektir.Git=>App_Start/RoutConfig
        //çalıştırmak için tarayıcıda=> H/Merhaba şekilde girilirse o sayfaya gider.
        public string Merhaba()
        {
            return "Merhaba, ilk Mvc Uygulamam";
        }
    }
}