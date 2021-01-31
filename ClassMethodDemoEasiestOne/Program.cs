using System;
using System.Collections.Generic;

namespace ClassMethodDemoEasiestOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.WriteLine("Welcome to your banking account manager!");
                Console.WriteLine("..");
                Console.WriteLine("..");
                Console.WriteLine("..");
                Console.WriteLine("..");             

                Customer customer1 = new Customer();
                customer1.Name = "Yunus";
                customer1.Surname = "Kaydan";
                customer1.Id = "001";
                customer1.CreditPoint = "45";

                Customer customer2 = new Customer();
                customer2.Name = "Koray";
                customer2.Surname = "Vatan";
                customer2.Id = "002";
                customer2.CreditPoint = "55";
                
                


                List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);

                Console.WriteLine(customers.Count);
                CustomerManager customerManager = new CustomerManager();

                Console.WriteLine(customers.Count);

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname);
                }

              
               customerManager.AddCustomer(customers);
               
               customerManager.ListCustomer(customers);
                
                Console.WriteLine(customers.Count);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname);
            }



        }
    }
}
