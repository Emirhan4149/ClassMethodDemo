using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
      public void Add(Customer customer)
        {
            Console.WriteLine("Adı : " + customer.CustomerName + " " + customer.CustomerSurname+" - Id : "+customer.Id);
            Console.ReadKey();
        }
        public void CustomerList(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Identification Number : "+customer.IdentificationNumber);
                Console.WriteLine("Id : "+customer.Id);
                Console.WriteLine("Customer Name : "+customer.CustomerName+" "+customer.CustomerSurname+" "+"Age : "+customer.Age);
                Console.WriteLine("-----------");
                Console.ReadKey();
            }
        }
        public void Remove(Customer customer)
        {
            string confirmation;
         Console.WriteLine(customer.CustomerName+" "+customer.CustomerSurname+ " Do you want to remove her contact from the customer list? (Yes/No): ");
            confirmation = Console.ReadLine();
            if (confirmation == "Yes")
            {
                Console.WriteLine(customer.CustomerName+" "+customer.CustomerSurname+" Id:"+customer.Id+ " Customer successfully removed..");
            }
            else
            {
                Console.WriteLine("You are return to the home screen, please wait");
            }
        }

    }
    
}
