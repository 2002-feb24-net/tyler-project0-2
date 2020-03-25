using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class Customer : DBVar
    {
        public Customer()
        {
            CustomerOrder = new HashSet<CustomerOrder>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<CustomerOrder> CustomerOrder { get; set; }

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

            if((UserName == "" ) || Password == "")
            {
                Console.WriteLine("You can't leave a field blank");
                UserNamePass();
            }

        }

        //public int GetCustomerID(string username, string password)
        //{
        //    var customerIDList = from customer in ctx.Customer
        //    where username == customer.Username
        //    && password == customer.Password
        //    select customer.CustomerId;
        //    var customerID = customerIDList.Single(); // unique combination so can return single, no duplicates possible from db
        //    return customerID;
        //}
    }

}