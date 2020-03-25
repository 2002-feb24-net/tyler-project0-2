using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class Store : DBVar, IUserChooses, IOutPut
    {
        public Store()
        {
            CustomerOrder = new HashSet<CustomerOrder>();
        }

        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zip { get; set; }

        public virtual ICollection<CustomerOrder> CustomerOrder { get; set; }

        public void DisplayDB()
        {
            Console.WriteLine($"We have a number of different stores in Texas");
            Console.WriteLine("Chose 1 through 4 to select");

            Console.WriteLine();
            foreach (var item in ctx.Store)
            {
                Console.WriteLine($"{item.City}");
            }

            Console.WriteLine();
        }

        public void Decide(int userIn)
        {
            Console.Write("Select a store: ");
            Console.ReadLine();
            //userIn = int.Parse(Console.ReadLine());
            //switch (userIn)
            //{
            //    case 1:
            //        Console.WriteLine("Welcome to a store");
            //        break;
            //    case 2:
            //        Console.WriteLine("Welcome to store 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("Welcome to store 3");
            //        break;
            //    case 4:
            //        Console.WriteLine("Welcome to store 4");
            //        break;
            //    default:
            //        Console.WriteLine("That is not an option. Try again");
            //        Decide(userIn);
            //        break;
            //}
        }

        public void GroupStore(int num)
        {
            try
            {
                DisplayDB();
                Decide(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("That option is not valid.");
                Decide(num);
            }
        }
    }
}
