using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Onur";
            customer1.SurName = "Dönmez";
            customer1.NationalNo = "12345678910";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Abdullah";
            customer2.SurName = "Dönmez";
            customer2.NationalNo = "12345678910";

            Customer[] customers = { customer1 , customer2};

            CustomerManager customerManager = new CustomerManager();

            customerManager.ShowCustomers(customers);

            customerManager.Uptade(customer1);

            customerManager.Add(customer1);

            customerManager.Delete(customer2);

        }
    }
}
