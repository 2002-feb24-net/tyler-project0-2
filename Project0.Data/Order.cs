using Project0.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project0.Data
{
    public class Order
    {

        public Store PickStore()
        {
            using (var ctx = new Project0Context())
            {
                int count = 1;
                string cityName = "";

                Console.WriteLine($"Welcome! We have restruans in Texas");
                Console.WriteLine();

                foreach (var item in ctx.Store)
                {
                    Console.WriteLine($"\t {item.City}");
                    count++;
                }
                Console.WriteLine();

                Console.Write("Enter the city: ");

                using (var con = new Project0Context())
                {
                    var userIn = Console.ReadLine();
                    var store = con.Store.FirstOrDefault(s => s.City == userIn);
                    if (store == null)
                    {
                        Console.WriteLine();
                        Console.Write("That's not an option. Try again: ");
                    }
                    return store;
                }



            }
        }

//        public int Decide()
//        {
//            using(var con = new Project0Context())
//            {
///*                var store = con.Store.FirstOrDefault(s => s.City == userIn);
//*/             /*   if(store == null)
//                { 
//                    Console.WriteLine();
//                    Console.Write("That's not an option. Try again: ");
//                    Decide(userIn);

//                }*/

//                int num3 = 0;
//                int num4 = 1;

//                string message = "Welcome to the Pizza Planet Console Application!";
//                Console.WriteLine(message);
//                Border(message);

//                Console.WriteLine($"Press 8 to go to previous menu");
//                Console.WriteLine("Press 0 to exit");
//                Console.WriteLine();

//                // Display food options
//                //foreach (var item in context.ProductGroup)
//                //{
//                //    Console.WriteLine($"{item.GroupId}. \t {item.GroupName}");
//                //}
//                //Console.WriteLine();
//                //Console.Write("What would you like? ");

//                //var GroupIdInput = Console.ReadLine();
//                ///*if (num4 == 1)
//                //{*/
//                //var GroupId = int.Parse(GroupIdInput);
//                //return GroupId;

//                    //PageStruct(userIn);
//                    /*switch (userIn)
//                    {
//                        case 1:
//                            return 1;
//                            break;
//                        case 2:
//                            PlaceOrder(2, store);
//                            break;
//                        case 3:
//                            PlaceOrder(3, store);
//                            break;
//                        case 4:
//                            PlaceOrder(4, store);
//                            break;
//                        case 5:
//                            PlaceOrder(5, store);
//                            break;
//                        case 8:
//                            var o2 = new Order();
//                            var store = o2.PickStore();
//                            return store;
//                            break;
//                        case 0:
//                            Console.WriteLine("Good bye!");
//                            Environment.Exit(0);
//                            break;
//                        default:
//                            Decide(userIn);
//                            break;
//                    }*/

//               /* }*/

//            }

            


//        }

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

        /*public void Intro()
        {
            int num3 = 0;
            int num4 = 1;

            Prompt();
            ExitBAck();
            DisplayDB(num3);
            Decide(num4);

        }*/

        


        //public void DisplayFoodOptions()
        //{
           

        //    foreach (var item in context.ProductGroup)
        //    {
        //        Console.WriteLine($"{item.GroupId}. \t {item.GroupName}");
        //    }
        //    Console.WriteLine();
        //    Console.Write("What would you like? ");
        //}

       

        public void ExitBAck()
        {
            Console.WriteLine($"Press 8 to go to previous menu");
            Console.WriteLine("Press 0 to exit");
            Console.WriteLine();
        }



        /*public void Decide(int userIn)
        {
            userIn = int.Parse(Console.ReadLine());

            Store store;
            //PageStruct(userIn);
            switch (userIn)
            {
                case 1:
                    PlaceOrder(1, store);
                    break;
                case 2:
                    PlaceOrder(2 , store);
                    break;
                case 3:
                    PlaceOrder(3, store);
                    break;
                case 4:
                    PlaceOrder(4, store);
                    break;
                case 5:
                    PlaceOrder(5, store);
                    break;
                case 8:
                    var o2 = new Order();
                    var store = o2.PickStore();
                    return store;
                    break;
                case 0:
                    Console.WriteLine("Good bye!");
                    Environment.Exit(0);
                    break;
                default:
                    Decide(userIn);
                    break;
            }
        }*/



        //public void PlaceOrder(int groupID, Store store, Customer customer)
        //{
        //    using (var ctx = new Project0Context())
        //    {

        //        var productGroup = ctx.ProductGroup.FirstOrDefault(a => a.GroupId == groupID);
        //        var productsInGroup = ctx.Product.FirstOrDefault(b => b.ProductId == productGroup.GroupId);



        //        string select = "";



        //        string mesg = "Welcome to the " + productGroup.GroupName + " Page!";
        //        Console.WriteLine(mesg);
        //        Border(mesg);
        //        var listOfType = from type in ctx.Product // type of food
        //                         where type.ProductGroupId == groupID
        //                         select type;


        //        /* foreach (var item in listOfType)
        //         {
        //             Console.WriteLine($"'{item.ProductName}' ");
        //         }
        //         Console.WriteLine();
        //         Console.WriteLine();*/

        //        Console.WriteLine("Press the corresponding number: ");

        //        //displays products
        //        foreach (var item2 in listOfType)
        //        {
        //            Console.WriteLine($"{item2.ProductId} {item2.ProductName} {productGroup.GroupName} ${item2.Price}");
        //        }

        //        Console.Write("Enter number to select");
        //        var pickedProductId = int.Parse(Console.ReadLine());
        //        var price = ctx.Product.FirstOrDefault(x => x.ProductId == pickedProductId);

        //        // find product id for product name
        //        var today = new DateTime();

        //        var order = new CustomerOrder
        //        {
        //            StoreId = store.Id,
        //            CustomerId = customer.Id,
        //            OrderDate = DateTime.Now.Date,
        //            Total = price.Price


        //        };
        //        ctx.Add(order);
        //        ctx.SaveChanges();



        //        //SelectOrder(select);
        //        int num5 = 0;
        //        int num6 = 0;

        //        //Console.WriteLine("Great choice! Are you ready to check out? (y/n)");
        //        //string checkout = Console.ReadLine();
        //        //if (!(checkout == "y"))
        //        //{
        //        //    Console.WriteLine("Added to your cart");
        //        //    Console.WriteLine();

        //        //    /*DisplayDB(num5);
        //        //    Decide(num6);*/
        //        //}

        //        //else
        //        //{
        //        //    DateTime ymD = new DateTime();
        //        //    var todayMonth = ymD.ToString("yyyy-mm-dd");
        //        //    //var storeInfo = from type in ctx.CustomerOrder
        //        //    //                where type.Customer.FirstName == customerName
        //        //    //                select type;

        //        //    var date = DateTime.Now.Date;

        //        //    Console.WriteLine("Your total order is :");
        //        //    Console.WriteLine($"Customer ID: {customer.Id} Total Price: {price.Price} Date Order: {DateTime.Now.Date}");
        //        //    Console.WriteLine();
        //        //    Console.WriteLine("Good-bye seeo you soon!");



        //        //}
        //    }
        }
        
    }


