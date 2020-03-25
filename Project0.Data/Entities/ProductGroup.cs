using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class ProductGroup : DBVar, IUserChooses, IOutPut
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public void DisplayDB()
        {
            Console.WriteLine("Welcome! Select 1 through 5 for food");
            ExitBack();

            foreach (var item in ctx.ProductGroup)
            {
                Console.WriteLine($"{item.GroupName}");
            }
            Console.WriteLine();
        }

        public void Decide(int userIn)
        {
            try
            {
                _ = new Product();

                Console.Write("Select a number: ");
                userIn = int.Parse(Console.ReadLine());

                switch (userIn)
                {
                    case 1:
                        GroupProduct("Pizza");
                        break;
                    case 2:
                        GroupProduct("Wings");
                        break;
                    case 3:
                        GroupProduct("Sides");
                        break;
                    case 4:
                        GroupProduct("Desert");
                        break;
                    case 0:
                        Console.WriteLine("Good-bye!");
                        Environment.Exit(0);
                        break;
                    case 8:
                        store1.GroupStore(userIn);
                        break;
                    default:
                        Decide(userIn);
                        break;
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("That is not a valid option");
                Decide(userIn);
            }

                
                

            }

        public void ProductChoices(string type)
        {
            Console.Write("Type");
            foreach (var item in ctx.Product)
            {
                if (item.Type == type)
                {
                    Console.Write($"'{item.ProductName}'");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void ProductAndPrices(string text)
        {
            foreach (var item in ctx.Product)
            {
                if (item.Type == text)
                {
                    Console.WriteLine($"{item.ProductName} {item.Type} {item.Price}");
                }
            }
        }

        public void Greetings(string message)
        {
            message = "Welcome to our Store";

            Console.WriteLine(message);
            Border(message);
        }

        private void Border(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void GroupProduct(string s)
        {
            Greetings(s);
            ProductChoices(s);
            ProductAndPrices(s);

        }
    }
}
