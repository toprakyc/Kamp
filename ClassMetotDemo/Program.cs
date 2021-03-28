using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 102936;
            musteri1.Name = "Mark";
            musteri1.Surname = "Zuckerberg";
            musteri1.CreditPoint = 9;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 213843;
            musteri2.Name = "Elon";
            musteri2.Surname = "Musk";
            musteri2.CreditPoint = 8;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 787421;
            musteri3.Name = "Faber";
            musteri3.Surname = "Castell";
            musteri3.CreditPoint = 5;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("---------------------Customer-Add---------------------------");
            musteriManager.AddCustomer(musteri1);
            musteriManager.AddCustomer(musteri2);
            musteriManager.AddCustomer(musteri3);
            Console.WriteLine("---------------------Customer-Del---------------------------");
            musteriManager.DelCustomer(musteri1);
            musteriManager.DelCustomer(musteri2);
            musteriManager.DelCustomer(musteri3);
            Console.WriteLine("---------------------Customer-List---------------------------");
            musteriManager.ListAllCustomers(musteriler);
        }
    }
}
