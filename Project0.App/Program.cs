using Project0.Data;
using Project0.Data.Entities;
using System;
using System.Linq;

namespace Project0.App
{
    class Program
    {
        static void Main()
        {
            using var ctx = new Project0Context();
            var current = HaveYouBeenHereBefore();
            Console.WriteLine($"Weclome {current.FirstName}");
            var start = new StartApp();
            start.MainMenu();
            var OrderMain = new OrderHelp();
            string mainOrder = OrderMain.CustomerOrder();

            var customerTotal = ctx.Product.FirstOrDefault(m => m.ProductName == mainOrder);


            var order = new CustomerOrder
            {
                StoreId = 2,
                OrderDate = DateTime.Now.Date,
                Total = customerTotal.Price,
                CustomerId = current.Id,
            };

            ctx.Add(order);
            try
            {
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Your order is added.");
            }


        }

        public static Customer HaveYouBeenHereBefore()
        {
            var currentCustomer = new UserSystem();

            Console.Write("Welcome! Have you been here before? (y/n):");
            string mainUserInput = Console.ReadLine();

            try
            {
                switch (mainUserInput)
                {
                    case "y":
                        return currentCustomer.OldCustomer();

                    case "n":
                        return currentCustomer.AddCustomer();
                    default:
                        Console.WriteLine("Not a valid option. Try again");
                        return HaveYouBeenHereBefore();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You have to enter (y/n) Try again");
                return HaveYouBeenHereBefore();
            }
        }
    }

}

//            
//.
//            
//            