using System;

class ReplitOdev
{
    public static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.UrunAdi = "Cepli Sarı Basic Tişört";
        product1.UrunFiyati = 129.90;
        product1.UrunIndirimOrani = "%20";

        Product product2 = new Product();
        product2.UrunAdi = "Dar Kesim Pantolon";
        product2.UrunFiyati = 119.90;
        product2.UrunIndirimOrani = "%30";

        Product[] products = new Product[] { product1, product2 };

        Console.WriteLine("-------------------for----------------------");
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine("Ürün Adi: " + products[i].UrunAdi +
                "| Ürün Fiyati: " + products[i].UrunFiyati +
                "| Ürün indirim Orani: " + products[i].UrunIndirimOrani);
        }

        Console.WriteLine("-----------------foreach--------------------");
        foreach (Product product in products)
        {
            Console.WriteLine("Ürün Adi: " + product.UrunAdi +
                "| Ürün Fiyati: " + product.UrunFiyati +
                "| Ürün indirim Orani: " + product.UrunIndirimOrani);
        }

        Console.WriteLine("-----------------while--------------------");
        int a = 0;
        while (a < products.Length)
        {
            Console.WriteLine("Ürün Adi: " + products[a].UrunAdi +
                "| Ürün Fiyati: " + products[a].UrunFiyati +
                "| Ürün indirim Orani: " + products[a].UrunIndirimOrani);
            a++;
        }
    }
}

class Product
{
    public string UrunAdi { get; set; }

    public double UrunFiyati { get; set; }

    public string UrunIndirimOrani { get; set; }
}