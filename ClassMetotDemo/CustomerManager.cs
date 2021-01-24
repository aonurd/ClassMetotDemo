using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
           
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Uptade(Customer customer)
        {
            Console.WriteLine("Müşteri Güncellendi");
        }

        public void Delete(Customer customer)
        {
          
            Console.WriteLine("Müşteri Silindi");
        }

        public void ShowCustomers(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name +  " "  +  customer.SurName);
            }
        }
    }
}
