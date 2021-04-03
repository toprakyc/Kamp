using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacCrediManager ihtiyacCrediManager = new IhtiyacCrediManager();
            //ihtiyacCrediManager.Calculate();

            //KonutCrediManager konutCrediManager = new KonutCrediManager();
            //konutCrediManager.Calculate();

            //TasitCrediManager tasitCrediManager = new TasitCrediManager();
            //tasitCrediManager.Calculate();

            Console.WriteLine("----------------------------------------");

            ICrediManager ihtiyacCrediManager1 = new IhtiyacCrediManager();
            ICrediManager konutCrediManager1 = new KonutCrediManager();
            ICrediManager tasitCrediManager1 = new TasitCrediManager();
            //demekki interfacelerde kendilerini implement eden sınıfların
            //referanslarını tutabilir tıpkı base classlar gibi..

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafCrediManager(), new List<ILoggerService>() 
            {new DatabaseLoggerService(), new SmsLoggerService() }) ; //polymorphism
                                                           //ne yazarsak onun metodu
                                                           //çalışır(abstraction)

            List<ICrediManager> krediler = new List<ICrediManager>() { ihtiyacCrediManager1, 
                konutCrediManager1, tasitCrediManager1 };
            //basvuruManager.CrediOnBilgilendirmesiYap(krediler);
            

        }
    }
}
