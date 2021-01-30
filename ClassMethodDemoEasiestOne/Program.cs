using System;

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
            Console.WriteLine("Process are:");
            Console.WriteLine("1:Create new account");
            Console.WriteLine("2:List accounts");
            Console.WriteLine("3:Remove Account");
            Console.WriteLine("Please write your process number: ");


            Customer customer1 = new Customer();
            customer1.Name = "Yunus";
            customer1.Surname = "Kaydan";
            customer1.Id = "001";
            customer1.CreditPoint = 45;

            Customer customer2 = new Customer();
            customer2.Name = "Koray";
            customer2.Surname = "Vatan";
            customer2.Id = "002";
            customer2.CreditPoint = 55;


                


            CustomerManager customerManager = new CustomerManager();

            Customer[] customers = new Customer[] { customer1, customer2};

            string  input = Console.ReadLine();
            if (input == "1")
            {

                customerManager.AddCustomer(customer1);
                

            }

            else if (input == "2" )
            {

                Console.WriteLine("Accounts are listed below: ");
                customerManager.ListCustomer(customers);
               
            }

            else if (input == "3")
            {
                customerManager.RemoveCustomer(customer1);
            }
        }
    }
}
