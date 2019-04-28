using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetWorld.Entity
{
    public class DataContext:DbContext
    {
        public DataContext():base("dataConnection")  {
            //projede varsayılan veritabanını oluşturmaması için kullanılıdı.
            //connectionStrings dataConnection isimde olanı oluştur
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}