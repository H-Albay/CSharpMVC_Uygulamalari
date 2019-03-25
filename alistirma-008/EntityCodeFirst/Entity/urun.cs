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
        public int Fiyat { get; set; }
        public int StokAdeti { get; set; }
    }
}