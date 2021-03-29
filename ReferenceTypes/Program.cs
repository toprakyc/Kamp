using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10, sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1);

            int[] dizi1 = new int[] { 1, 2, 3 };
            int[] dizi2 = new int[] { 4, 5, 7 };
            dizi1 = dizi2;
            dizi2[1] = 99;
            Console.WriteLine(dizi1[1]);

            Person person1 = new Person();
            Person person2 = new Person();

            person2.FirstName = "Toprak";
            person1 = person2;
            Console.WriteLine("person1.FirstName: " + person1.FirstName);

            person2.FirstName = "Yucel";
            Console.WriteLine("person1.FirstName: " + person1.FirstName); //reference type old. sonuc değisir
            
            
            
            //base class'a yani temel sınıfa; miras alan sınıftan atama
            //yapabiliriz. Burada base class Person, m. alan customer veya
            //employee dir. bu arada miras alan sınıf, base'i inherit ediyor deriz
            
            Customer customer = new Customer();
            customer.FirstName = "Sabri";
            customer.CreditCardNumber = "918503135"; //boxing için

            person1 = customer;     //alt classlarda geçiş var..
            Console.WriteLine("person1.FirstName: " + customer.FirstName);
            Console.WriteLine(((Customer)person1).CreditCardNumber); //boxing yaptık.
                                                                     //normalde person
                                                                     //üzerinden erişemezdik

            Employee employee = new Employee();
            employee.FirstName = "Beyaz";

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //base class : Person
    class Customer:Person //inheritence
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person) //person türünde olsada; employee'de
                                       //customer'da gönderebiliyorum. Çünkü base person
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
