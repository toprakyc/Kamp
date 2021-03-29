using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {   //operasyon sınıfları ile birşeyler yaptırırız
        public void Add(Product product)
        {
            Console.WriteLine("Ürün eklendi! Ürün adı: " + product.ProductName);
        }
        public void Update(Product product)
        {
            Console.WriteLine(" Ürün Güncellendi! Ürün adı: " + product.ProductName);
        }

    }
}
