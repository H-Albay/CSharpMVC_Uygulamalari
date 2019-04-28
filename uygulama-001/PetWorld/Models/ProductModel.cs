using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetWorld.Models
{
    public class ProductModel
    {
        //Veritabanı üzerinde paketleme işlemi yapar (Model)
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public int CategoryId { get; set; } //foreign key
    }
}