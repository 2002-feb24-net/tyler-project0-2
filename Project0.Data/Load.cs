using Project0.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Project0.Data
{
    public class Load
    {
        private static readonly Project0Context ctx = new Project0Context();
        public static Order o1 = new Order();
        public void LoadMethod(string s)
        {
            try
            {
                using (var ctx = new Project0Context())
                {
                    var c = ctx.Customer.FirstOrDefault(p => p.FirstName == s);
                    Console.WriteLine($"Customer Name: {c.FirstName} {c.LastName} Customer ID: {c.Id}");
                    Console.WriteLine();
                    Console.Write("Please any button to go back: ");
                    Console.ReadLine();
                    MainMenu();
                }
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Couldn't find that name");
                Console.WriteLine();
                Console.Write("Press any button to go back");
                Console.ReadLine();
                MainMenu();
            }
        }

        public void MainMenu()
        {
            Customer c1 = new Customer();
            string[] options = { "Add a customer", "Search for a customer", "Order", "Search for a customer's order details", "Search for orders by the store's ID" };
            int num1 = 0;

            for (int i = 1; i <= options.Length; i++)
            {
                Console.WriteLine($"{i}. \t {options[i- 1]}");
            }

            Console.WriteLine();
            Console.Write("Press a number: ");
            Decide(num1, c1);
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
                    Console.WriteLine("Save did work.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Save didn't work.");
                    MainMenu();
                }
        }

        public void SearchCustoemrOrderInStore()
        {
            Console.WriteLine("Store's ID are 1 through 4");
            using(var ctx = new Project0Context())
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
                MainMenu();
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
            catch(FormatException)
            {
                Console.WriteLine("You enter a wrong character. Try again");
                UserNamePass(cust1);
            }

            if (cust1.Password != password2)
                UserNamePass(cust1);
        }

        public Customer OldCustomer(Customer c1)
        {
            using(var ct  = new Project0Context())
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
                    Again(text3, c1);
                    return new Customer(); // all null values
                    
                }
                
            }
        }

        public void Again(string text, Customer c2)
        {
            Console.Write("Would you like to try again? (y/n)");
            string tryAgain = Console.ReadLine();

            switch(tryAgain)
            {
                case "y":
                    OldCustomer(c2);
                    break;
                case "n":
                    AddCustomer(c2);
                    break;
                default:
                    Console.WriteLine("That's not option");
                    Again(text, c2);
                    break;
            }
        }

        public void Decide(int userIn, Customer customer)
        {
            var cust1 = new Customer();
            var load = new Load();
            try
            {
                userIn = int.Parse(Console.ReadLine());

                switch (userIn)
                {
                    case 1:
                        AddCustomer(cust1);
                        break;
                    case 2:
                        SearchCust(load);
                        break;
                    case 3:
                        var order = new Order();
                        var store = order.PickStore();
                        var groupID = order.Decide();
                        order.PlaceOrder(groupID, store, customer);
                        break;
                    case 4:
                        SearchCustoemrOrderInStore();
                        break;
                    case 5:
                        SearchForCustomerOrder();
                        break;
                    default:
                        Console.WriteLine("That's not an option");
                        MainMenu();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter something");
                Console.WriteLine();
                MainMenu();
            }
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
                MainMenu();
            }
        }

        public void SearchCust(Load l1)
        {
            Console.Write("Enter the name you want search :");
            string mainIn = Console.ReadLine();

            l1.LoadMethod(mainIn);
            Console.WriteLine();
        }
    }
}
