using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public void NewCustomer()
        {
            try
            {
                Console.Write("What is your first name");
                FirstName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("What is your last Name");
                LastName = Console.ReadLine();
                Console.WriteLine();
                UserNamePass();
            }

            catch (FormatException)
            {
                Console.WriteLine("You have to input a word. Try again");
                NewCustomer();
            }
        }

        public void UserNamePass()
        {
            Console.Write("Username: ");
            UserName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Password: ");
            Password = Console.ReadLine();
            Console.WriteLine();
        }
    }
}
