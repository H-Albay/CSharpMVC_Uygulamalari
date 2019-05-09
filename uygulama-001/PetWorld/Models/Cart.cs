using PetWorld.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetWorld.Models
{
    public class Cart
    {
        private List<CartLines> _cardLines = new List<CartLines>();

        public List<CartLines> CartLines
        {
            get { return _cardLines; }
        }

        public void AddProduct(Product product, int quantity)
        {
            var line = _cardLines.Where(i => i.Product.Id == product.Id).FirstOrDefault();
            if (line == null)
            {
                _cardLines.Add(new CartLines() { Product = product, Quantity = quantity });
            }
            else
            {
                quantity += quantity
;
            }
        }

        public void DeleteProduct(Product product)
        {
            _cardLines.RemoveAll(i => i.Product.Id == product.Id);
         
        }

         public double Total()
        {
            return _cardLines.Sum(i => i.Product.Price * i.Quantity);
        }

        public void Clear()
        {
            _cardLines.Clear();
        }
    }
    public class CartLines
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}