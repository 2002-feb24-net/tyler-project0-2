﻿using Project0.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project0.App
{
    public class CustomerClassHelper
    {
        private static readonly Project0Context ctx = new Project0Context();

        public void SearchforCustomer()
        {
            try
            {
                using (var ctx = new Project0Context())
                {
                    Console.Write("Ener a a customer's name: ");
                    string name = Console.ReadLine();

                    var c = ctx.Customer.FirstOrDefault(p => p.FirstName == name);
                    Console.WriteLine($"Customer Name: {c.FirstName} {c.LastName} Customer ID: {c.Id}");
                    Console.WriteLine();
                    Console.Write("Please any button to go back: ");
                    Console.ReadLine();
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Couldn't find that name");
                Console.WriteLine();
                Console.Write("Press any button to go back");
                Console.ReadLine();
            }

            //Main method
        }


        public void AddCustomer(Customer cust1)
        {
            try
            {
                Console.Write("What is your first name: ");
                cust1.FirstName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("What is your last name: ");
                cust1.LastName = Console.ReadLine();
                Console.WriteLine();
                UserNamePass(cust1);
            }
            catch (FormatException)
            {
                Console.WriteLine("You didn't the connect type");
                AddCustomer(cust1);
            }

            ctx.Add(cust1);
            try
            {
                ctx.SaveChanges();
                Console.WriteLine("Added to Database.");
            }
            catch (Exception)
            {
                Console.WriteLine("Save didn't work.");
            }
        }


        public void SearchCustoemrOrderInStore()
        {
            Console.WriteLine("Store's ID are 1 through 4");
            using (var ctx = new Project0Context())
            {
                Console.Write("Enter a store's ID:");
                int searchstore = int.Parse(Console.ReadLine());
                var storeInfo = from type in ctx.CustomerOrder
                                where type.StoreId == searchstore
                                select type;

                Console.WriteLine();
                Console.WriteLine("List of all the stores");
                foreach (var item in storeInfo)
                {
                    Console.WriteLine($"OrderID: {item.OrderId} Cusermer ID: {item.CustomerId} Date Ordered: {item.OrderDate} Total: ${item.Total}");
                }
                Console.WriteLine();
                Console.Write("Press any button to go back: ");
                Console.ReadLine();
                //MainMenu();
            }
        }

        public void UserNamePass(Customer cust1)
        {
            string password2 = "";


            try
            {
                Console.Write("Enter a username: ");
                cust1.UserName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter a password: ");
                cust1.Password = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Verify password: ");
                password2 = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("You enter a wrong character. Try again");
                UserNamePass(cust1);
            }

            if (cust1.Password != password2)
                UserNamePass(cust1);
        }

        public void SearchForCustomerOrder()
        {
            Console.WriteLine();
            using (var ctx = new Project0Context())
            {
                Console.Write("Enter a Customer's name:");
                string customerName = Console.ReadLine();
                var storeInfo = from type in ctx.CustomerOrder
                                where type.Customer.FirstName == customerName
                                select type;

                Console.WriteLine();
                Console.Write("List of all ");
                Console.WriteLine();
                foreach (var item in storeInfo)
                {
                    Console.WriteLine($"OrderID: {item.OrderId} Store ID: {item.StoreId} Date Ordered: {item.OrderDate} Total: ${item.Total}");
                }
                Console.WriteLine();
                Console.Write("Press any button to go back: ");
                Console.ReadLine();
                //MainMenu();
            }
        }

        public Customer OldCustomer(Customer c1)
        {
            using (var ct = new Project0Context())
            {
                try
                {
                    Console.Write("What is your username: ");
                    string text = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("What is your password: ");
                    string text2 = Console.ReadLine();

                    var customer = ct.Customer.FirstOrDefault(a => a.UserName == text);
                    if (customer.Password == text2)
                    {
                        Console.WriteLine($"Welcome back {customer.FirstName}! ");

                    }
                    return customer;
                }
                catch (NullReferenceException)
                {
                    string text3 = "";

                    Console.WriteLine("Couldn't find that user:");
                    //Again(text3, c1);
                    return new Customer(); // all null values

                }

            }
        }
    }
}
