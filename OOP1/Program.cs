using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //bu şekildede tanımlanır..
            Product product2 = new Product{Id = 2, CategoryId = 5, 
                ProductName = "Kalem", UnitPrice = 35, UnitsInStock = 5};

            //PascalCase   //camelCase
            //class ve class değişkeni C# ve
            //java case sensitive'dir
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //referans tip olduğu için productName değişir
            //int double bool değer tip
            //dizi, class, abstract class, interface, referans tiptir ve
            //atamalar bellek adresi üzerinden yapılır.

        }
    }
}
