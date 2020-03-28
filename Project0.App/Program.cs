using Project0.Data;
using Project0.Data.Entities;
using System;

namespace Project0.App
{
    class Program
    {
        static void Main()
        {
            var load = new Load();
            var mainCust = new Customer();

            Console.Write("Welcome! Have you been here before? (y/n):  ");

            string mainInput = Console.ReadLine();
            Console.WriteLine();

            Customer customer = new Customer();
                switch (mainInput)
                {
                    case "y":
                        customer = load.OldCustomer(mainCust); // returns customer object from db
                        break;
                    case "n":
                        load.AddCustomer(mainCust);
                        break;
                    default:
                        Console.WriteLine("That's not an option");
                        Console.WriteLine();
                        
                        break;
                }




            /*L1.MainMenu();*/
            string[] options = { "Add a customer", "Search for a customer", "Order", "Search for a customer's order details", "Search for orders by the store's ID" };
            int num1 = 0;

            for (int i = 1; i <= options.Length; i++)
            {
                Console.WriteLine($"{i}. \t {options[i - 1]}");
            }

            Console.WriteLine();
            Console.Write("Press a number: ");
            /*            Decide(num1); */
            var cust1 = new Customer();
            try
            {
                var userIn = int.Parse(Console.ReadLine());

                switch (userIn)
                {
                    case 1:
                        load.AddCustomer(cust1);
                        break;
                    case 2:
                        load.SearchCust(load);
                        break;
                    case 3: // order
                        var order = new Order();
                        var store = order.PickStore();
                        var groupID = order.Decide();
                        order.PlaceOrder(groupID, store, customer);
                        break;
                    case 4:
                        load.SearchForCustomerOrder();
                        
                        break;
                    case 5:
                        load.SearchCustoemrOrderInStore();
                        break;
                    default:
                        Console.WriteLine("That's not an option");
                        load.MainMenu();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter something");
                Console.WriteLine();
                load.MainMenu(); // back to the top if error
            }

            //load.MainMenu();

        }

        static void NewOrOld(Customer mainCust)
        {
            string mainInput = Console.ReadLine();
            Console.WriteLine();
            var L1 = new Load();

            switch (mainInput)
            {
                case "y":
                    L1.OldCustomer(mainCust);
                    break;
                case "n":
                    L1.AddCustomer(mainCust);
                    break;
                default:
                    Console.WriteLine("That's not an option");
                    Console.WriteLine();
                    NewOrOld(mainCust);
                    break;
            }
        }

    }

}
