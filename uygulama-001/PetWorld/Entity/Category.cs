using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetWorld.Entity
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Kategori Adı")]
        [StringLength(maximumLength:23,ErrorMessage ="En fazla 23 karakter girebilirsiniz.")]
        public string Name { get; set; }
        [StringLength(maximumLength: 200, ErrorMessage = "En fazla 200 karakter girebilirsiniz.")]
        [DisplayName("Açıklama")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }

    }
}