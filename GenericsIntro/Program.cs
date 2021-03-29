using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); //Generic classtır
            isimler.Add("Ateş");

            Console.WriteLine(isimler.Lenght);  //kendi yazdığımız Length func.
            isimler.Add("Hava");

            Console.WriteLine(isimler.Lenght);

            foreach (var isim in isimler.Items) //got it later 
            {
                Console.WriteLine(isim);
            }
        }
    }
}
