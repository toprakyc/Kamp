using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GCustomer gcustomer1 = new GCustomer();
            gcustomer1.Id = 12345;
            gcustomer1.CustomerNumber = "12345";
            gcustomer1.Name = "Sönmez";
            gcustomer1.Surname = "Reis";
            gcustomer1.TcNo = "12345789010";

            TCustomer tcustomer1 = new TCustomer();
            tcustomer1.Id = 12345;
            tcustomer1.CustomerNumber = "12345";
            tcustomer1.CompanyName = "Toprak Holding";
            tcustomer1.TaxNo = "12345";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(tcustomer1); 
            customerManager.Add(gcustomer1); //burada base class'ın referans
                                             //tutucu olduğunu görüyoruz hem tüzel
                                             //hemde bireysel varlıkların referansını tutuyor

        }
    }
}
