using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void AddCustomer(Musteri musteri)
        {
            Console.WriteLine("Customer has been added! Customer Information: " 
                + musteri.Name + " " + musteri.Surname);
        }

        public void DelCustomer(Musteri musteri)
        {
            Console.WriteLine("Customer has been deleted! Customer Information: "
                + musteri.Name + " " + musteri.Surname);
        }

        public void ListAllCustomers(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Name Surname: " + musteri.Name + " " + musteri.Surname + " Id: " 
                    + musteri.Id + " Credit Point: " + musteri.CreditPoint);
            }
        }
    }
}
