using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemoEasiestOne
{
    class CustomerManager
    {
        Customer createCustomer = new Customer();

        public void AddCustomer(List<Customer> customers)
        {
            Console.WriteLine("Please write your ID Number: ");
            createCustomer.Id = Console.ReadLine();
            Console.WriteLine("Please write your name: ");
            createCustomer.Name = Console.ReadLine();
            Console.WriteLine("Please write your surname: ");
            createCustomer.Surname = Console.ReadLine();
            Console.WriteLine("Please write your credit card number: ");
            createCustomer.CreditPoint = Console.ReadLine();
            customers.Add(createCustomer);

            
        }

        public void ListCustomer(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customers are listed below.");
                Console.WriteLine("Customer Id: "+ customer.Id);
                Console.WriteLine("Customer Name: "+ customer.Name);
                Console.WriteLine("Customer Surname: "+ customer.Surname);
                Console.WriteLine("Customer Credit Card Number: "+ customer.CreditPoint);
                Console.WriteLine("----------------");
            }
        }

        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine("Customer is completely removed! :"+ customer.Id + " : "+customer.Name );

        }
    }
}
