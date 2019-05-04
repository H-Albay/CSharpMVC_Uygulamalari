using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Web;

namespace PetWorld.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklama")]
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool IsHome { get; set; } 
        public bool IsApproved { get; set; }

        
        public int CategoryId { get; set; } //foreign key
        public Category Category { get; set; }
    }
}