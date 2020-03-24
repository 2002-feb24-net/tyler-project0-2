using Project0.Data;
using Project0.Data.Entities;
using System;

namespace Project0.App
{
    class Program : DBVar
    {
        static void Main()
        {
            var start = new Begin();
            start.Intro();

            var cust1 = new Customer();
            NewOrOld(ctx, cust1);
            Console.WriteLine();

            var store1 = new Store();
            store1.DisplayDB();
        }

        public static void NewOrOld(Project0Context ctx, Customer cust1)
        {
            Console.Write("Are you a new customer (y/n): ");
            string yON = Console.ReadLine();

            switch (yON)
            {
                case "y":
                    cust1.NewCustomer();
                    ctx.Add(cust1);
                    ctx.SaveChanges();
                    break;
                case "n":
                    cust1.UserNamePass();
                    break;
                default:
                    Console.WriteLine("Sorry that's not an option. Try again");
                    NewOrOld(ctx, cust1);
                    break;
            }

        }
    }
}
