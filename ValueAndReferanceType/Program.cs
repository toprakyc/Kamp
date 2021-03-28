using System;

namespace RefAndOutKeywords

//Ref ve out keywordü değer tipli değişkenleri referans tipli değişken gibi davranma özelliği
//kazandırır. Ref ve out arasındaki fark ise;
//Ref de başlangıç değerini (initialize) belirtmek zorunludur. Out keywordünde böyle bir
//zorunluluk yoktur.
{
    class Program
    {
        static void Main(string[] args)
        {
            double value1 = 0.5;

            double value2 = 9.5;

            // Alt kısımda kredi hesaplama için oluşturulan methoda yukardaki değerler gönderildi
            // ve okunabilirlik açısından returnMethod değişkenine dönen değer aktarıldı.
            //ref keyword ile value1 adlı değişken gönderildi.
            double returnMethod = CreditCalculator(ref value1, value2);

            //Console ekranına yazdırıldı.
            Console.WriteLine(value1 + " * " + value2 + " = " + returnMethod);

            //ref - out olmasaydı console yazdırırken ilk oluşturulan değer "0.5" ekrana yazdırılacaktı.
            Console.WriteLine(value1);
        }

        //gönderilen ref keywordü ile karşılandı.
        static double CreditCalculator(ref double value1, double value2)
        {
            //ref ile gelen değer değiştirildi ve yukarıdaki  criterionValue1 değişkenin değerini değiştirdi. Referans tipli değişken gibi davranma özelliği kazandırdı.
            //ref - out ile belirtme işlemi yapılmış olmasaydı "3" değeri bu method içinde kalacaktı ve ölecekti. Ref - out ise, referans tip özelliği kazandırdı.

            value1 = 3;
            return value1 * value2;
        }
    }
}

//int, decimal, float, double, bool = değer tip STACKTE TUTAR İŞLEMLERİ ORADA YAPAR
//array, class, interface = referans tip HEAPTE TUTULUR