using Project0.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project0.Data
{
    public class Begin
    {
        public static Project0Context context = new Project0Context();
        public static CustomerOrder cart = new CustomerOrder();

        public void Prompt()
        {
            string message = "Welcome to the Pizza Planet Console Application!";
            Console.WriteLine(message);
            Border(message);
        }

        public void Border(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        //public void Intro()
        //{
        //    int num3 = 0;
        //    int num4 = 1;

        //    Prompt();
        //    ExitBAck();
        //    DisplayDB(num3);
        //    Decide(num4);

        //}

        //public void DisplayDB(int count)
        //{
        //    count = 1;
        //    int num1 = 0;

        //    foreach (var item in context.ProductGroup)
        //    {
        //        Console.WriteLine($"{count}. \t {item.GroupName}");
        //        count++;
        //    }
        //    Console.WriteLine();
        //    Console.Write("What would you like? ");
        //}

        //public void ExitBAck()
        //{
        //    Console.WriteLine($"Press 8 to go to previous menu");
        //    Console.WriteLine("Press 0 to exit");
        //    Console.WriteLine();
        //}

        //public void Decide(int userIn)
        //{
        //    userIn = int.Parse(Console.ReadLine());
        //    //PageStruct(userIn);
        //    switch(userIn)
        //    {
        //        case 1:
        //            PageStruct(1);
        //            break;
        //        case 2:
        //            PageStruct(2);
        //            break;
        //        case 3:
        //            PageStruct(3);
        //            break;
        //        case 4:
        //            PageStruct(4);
        //            break;
        //        case 5:
        //            PageStruct(5);
        //            break;
        //        case 8:
        //            var o2 = new Order();
        //            o2.PickStore();
        //            break;
        //        case 0:
        //            Console.WriteLine("Good bye!");
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            Decide(userIn);
        //            break;
        //    }
        //}

        //public void PageStruct(int num1)
        //{
        //    using (var ctx = new Project0Context())
        //    {

        //            var c = ctx.ProductGroup.FirstOrDefault(a => a.GroupId == num1);
        //            var d = ctx.Product.FirstOrDefault(b => b.ProductId == c.GroupId);



        //            string select = "";



        //            string mesg = "Welcome to the " + c.GroupName + " Page!";
        //            Console.WriteLine(mesg);
        //            Border(mesg);
        //            var list1 = from type in ctx.Product
        //                        where type.ProductGroupId == num1
        //                        select type;

        //            Console.Write("Type ");
        //            foreach (var item in list1)
        //            {
        //                Console.Write($"'{item.ProductName}' ");
        //            }
        //            Console.WriteLine();
        //            Console.WriteLine();

        //            foreach (var item2 in list1)
        //            {
        //                Console.WriteLine($"{item2.ProductName} {item2.ProductGroupId} ${item2.Price}");
        //            }
        //            //SelectOrder(select);
        //            BackAgain();
               
        //    }
        //}

        //public void SelectOrder(string orderIn)
        //{

        //    Console.Write("Would what you like? ");
        //    orderIn = Console.ReadLine();

        //    using(var ctx = new Project0Context())
        //    {
        //        int id = 1;
        //        var d = ctx.Product.FirstOrDefault(a => a.ProductName == orderIn);
        //        if(d == null)
        //        {
        //            Console.WriteLine("That order doesn't exsist. Try again");
        //            SelectOrder(orderIn);
        //        }
        //        else
        //        {
        //            var cOrder = new CustomerOrder();
        //            cOrder.StoreId = int.Parse(d.OrderId);
        //            cOrder.CustomerId = id;
        //            cOrder.OrderDate = DateTime.Now;
        //            cOrder.Total = d.Price;
        //            ctx.Add(cOrder);
        //            try
        //            {
        //                ctx.SaveChanges();
        //            }
        //            catch (Exception ex)
        //            {

        //                Console.WriteLine("Save didn't work");
        //                Console.WriteLine(ex.Message);
        //            }


        //        }
        //    }
        //}

        //public void BackAgain()
        //{
        //    int num5 = 0;
        //    int num6 = 0;

        //    Console.WriteLine("Great choice! Are you ready to check out? (y/n)");
        //    string checkout = Console.ReadLine();
        //    if (!(checkout == "y"))
        //    {
        //        Console.WriteLine("Added to your cart");
        //        Console.WriteLine();
        //        DisplayDB(num5);
        //        Decide(num6);
        //    }

        //    else
        //        Console.WriteLine($"Your total is $ total");

        }
    }

