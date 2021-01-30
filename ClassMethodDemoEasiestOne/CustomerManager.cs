using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemoEasiestOne
{
    class CustomerManager
    {
        
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Basariyla eklendi : "+ customer.Name);

        }

        public void ListCustomer(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customers are listed below.");
                Console.WriteLine("Customer Id: "+ customer.Id);
                Console.WriteLine("Customer Name: "+ customer.Name);
                Console.WriteLine("Customer Surname: "+ customer.Surname);
                Console.WriteLine("Customer Credit Point: "+ customer.CreditPoint);
                Console.WriteLine("----------------");
            }
        }

        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine("Customer is completely removed! :"+ customer.Id + " : "+customer.Name );

        }
    }
}
