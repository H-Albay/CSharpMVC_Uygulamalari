using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Etkinlik_WebApi.Models;
namespace Etkinlik_WebApi.Controllers
{
    public class DavetiyeController : ApiController
    {
        //[HttpGet] anahtar sözüğünü kullanmak yerine ilgili metotta get yada post yazıyorum.
        public IEnumerable<DavetiyeModel> GetKatilanlar()
        {
            return Veritabani.Liste.Where(i=>i.KatilmaDurumu ==true);
        }
        public IEnumerable<DavetiyeModel> GetKatilmayanlar()
        {
            return Veritabani.Liste.Where(i => i.KatilmaDurumu == false);
        }
        [HttpPost]
        public void Ekle(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                Veritabani.Add(model);
            }
        }
    }
}
