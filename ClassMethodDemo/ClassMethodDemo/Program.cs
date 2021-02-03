using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.IdentificationNumber = 15005678932;
            customer1.CustomerName = "Emirhan";
            customer1.CustomerSurname = "Türk";
            customer1.PhoneNumber=+905511824149;
            customer1.Age = 28;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.IdentificationNumber = 15078965413;
            customer2.CustomerName = "Alparslan";
            customer2.CustomerSurname = "Zeki";
            customer2.PhoneNumber= +905413401108;
            customer2.Age = 34;

            List<Customer> customers = new List<Customer> { customer1,customer2 };
            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("----- Welcome to System :) -----");
            Console.WriteLine("----- Press to 'Enter' continue -----");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("----- Customer Creation -----");
            customerManager.Add(customer1);
            Console.WriteLine("");
            Console.WriteLine("----- Customer List -----");
            customerManager.CustomerList(customers);
            Console.WriteLine("");
            Console.WriteLine("----- Customer Remove -----");
            customerManager.Remove(customer2);

        }
    }
}
