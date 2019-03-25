using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityCodeFirst.Entity
{
    public class DataContext : DbContext
    {
        //database ile ilişkileniriyorum neyi webconfig içindeki connectionStrings
        public DataContext():base("EntityCodeFirstConnection")
        {

        }
        //DataContext Entity DbContextten kalıtıldı.Burada amaç veritabanına erişim sağlamaktır.
        //Kod tarafında düzenlemeler yapmak için kullanılır.
        public DbSet<kategori> kategoriler { get; set; }
        public DbSet<urun> urunler { get; set; }

    }
}