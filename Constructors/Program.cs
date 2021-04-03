using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1, Name="Atıf", Surname="Haluk", City="İzmir" };
            
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Şaban";

            Customer customer2 = new Customer(2, "Halim", "Kırgız", "Konya"); //parametreli consu çalıştırır
            Console.WriteLine(customer2.Name);  //Customer class'ındaki parametreli
                                                //cons içinde eşitleme yapılmazsa erişilmiyor
        }

        class Customer
        {
            public Customer(int id, string name, string surname, string city)
            {
                Id = id;
                Name = name;
                Surname = surname;
                City = city;
            }
            public Customer() //default ctor.(parametresi olmayan) new leme yapınca çalışır.
            {
                Console.WriteLine("Ctor Çalıştı...");
            }
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string City { get; set; }
        }
    }
}
