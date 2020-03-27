using Project0.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Project0.Data
{
    public class Load : IUserChooses
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
                    Console.WriteLine($"{c.FirstName} {c.LastName} {c.Id}");
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
                MainMenu();
            }
        }

        public void MainMenu()
        {
            string[] options = { "Add a customer", "Search for a customer", "Order" };
            int num1 = 0;

            for (int i = 1; i <= options.Length; i++)
            {
                Console.WriteLine($"{i}. \t {options[i- 1]}");
            }

            Console.WriteLine();
            Console.Write("Press a number: ");
            Decide(num1);
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

        public int OldCustomer(Customer c1)
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

                    var p = ct.Customer.FirstOrDefault(a => a.UserName == text);
                    if (p.Password == text2)
                    {
                        Console.WriteLine($"Welcome back {p.FirstName}! ");
                        
                    }
                    return p.Id;
                }
                catch (NullReferenceException)
                {
                    string text3 = "";

                    Console.WriteLine("Couldn't find that user:");
                    Again(text3, c1);
                    return 0;
                    
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

        public void Decide(int userIn)
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
                        o1.PickStore();
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

        public void SearchCust(Load l1)
        {
            Console.Write("Enter the name you want search :");
            string mainIn = Console.ReadLine();

            l1.LoadMethod(mainIn);
            Console.WriteLine();
        }
    }
}
