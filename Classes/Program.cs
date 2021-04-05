using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "İstanbul";
            customer.FirstName = "Yucel";
            customer.LastName = "Toprak";
            customer.Id = 123458;

            Customer customer1 = new Customer
            {
                FirstName = "Kamil", LastName = "Kaya", Id = 123450, City = "İstanbul"
            };
            Console.WriteLine(customer1.FirstName);

            Console.ReadLine();
        }
    }
}
