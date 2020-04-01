using Project0.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project0.Data
{
    public class Login
    {
        private static readonly Project0Context ctx = new Project0Context();


        //This method will actvae if the customer has been here before
        public Customer AddCustomer()
        {
            var cust1 = new Customer();
            try
            {
                Console.Write("What is your first name: ");
                cust1.FirstName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("What is your last name: ");
                cust1.LastName = Console.ReadLine();
                Console.WriteLine();
                UserNamePass();
            }
            catch (FormatException)
            {
                Console.WriteLine("You didn't the connect type");
                AddCustomer();
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

            return cust1;
        }

        public void UserNamePass()
        {
            var cust1 = new Customer();
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
                UserNamePass();
            }

            if (cust1.Password != password2)
                UserNamePass();
        }

        public Customer OldCustomer()
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
                    if (customer.Password != text2)
                    {
                        Console.WriteLine("Sorry Username and Password didn't match. Try again");
                        return OldCustomer();

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
