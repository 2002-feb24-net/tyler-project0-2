using Project0.App;
using Project0.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Data
{
    public class StartApp
    {
        public static CustomerClassHelper helper = new CustomerClassHelper();
        public static Customer customer1 = new Customer();

        public void newOrOld()
        {
            Console.WriteLine("Have you been here before? (y/n)");
            string yesOrNO = Console.ReadLine();
            if (yesOrNO == "y")
            {
                var old = helper.OldCustomer();
            }
        }

        public void MainMenu()
        {
            int mainInput = 0;

            Customer c1 = new Customer();
            string[] options = { "Add a customer", "Search for a customer", "Order", "Search for a customer's order details", "Search for orders by the store's ID" };
            int num1 = 0;

            for (int i = 1; i <= options.Length; i++)
            {
                Console.WriteLine($"{i}. \t {options[i - 1]}");
            }

            Console.WriteLine();
            Console.Write("Press a number: ");
            Decide(mainInput);
        }

        public void Decide(int userIn)
        {
            try
            {
                userIn = int.Parse(Console.ReadLine());

                switch (userIn)
                {
                    case 1:
                        helper.AddCustomer();
                        MainMenu();
                        break;
                    case 2:
                        helper.SearchforCustomer();
                        MainMenu();
                        break;
                    case 3:
                        var storeHelp = new StoreHelper();
                        var myOrder = new OrderHelp();
                        var userStore = storeHelp.UserPicksStore();
                        string message = $"Welcome to the Pizza Planet Store on {userStore.Street}";
                        Console.WriteLine(message);
                        MessageBorder(message);
                        break;
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("That is not a valid option. Try again");
                Decide(userIn);
            }
        }

        public void MessageBorder(string text)
        {
            for(int a = 0; a <text.Length; ++a)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
