using Project0.Data;
using Project0.Data.Entities;
using System;

namespace Project0.App
{
    class Program : DBVar
    {
        static void Main()
        {
            int userMain = 0;

            var start = new Begin();
            start.Intro();

            var cust1 = new Customer();
            NewOrOld(ctx, cust1);
            Console.WriteLine();

            store1.GroupStore(userMain);
            pg1.DisplayDB();
            pg1.Decide(userMain);


        }

        //public static void AddToOrder(Customer c1)
        //{
        //    _ = new CustomerOrder
        //    {
        //        CustomerId = c1.Id,
        //        StoreId = store1.Id,
        //        Total =  o1

        //    };


        //}

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
