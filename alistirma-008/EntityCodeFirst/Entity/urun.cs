using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCodeFirst.Entity
{
    public class urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string Fiyat { get; set; }
        public string StokAdeti { get; set; }
    }
}