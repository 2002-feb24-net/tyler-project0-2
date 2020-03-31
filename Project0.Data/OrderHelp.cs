using Project0.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project0.Data
{
    public class OrderHelp
    {
        public string CustomerOrder()
        {
            using (var ctx = new Project0Context())
            {
                int counter = 1;
                foreach (var item in ctx.ProductGroup)
                {
                    Console.WriteLine($"{counter}. \t {item.ProductName}");
                    counter++;
                }
                Console.WriteLine();
                Console.Write("What would you like? ");

                int userInput = int.Parse(Console.ReadLine());
                String input = PageStructure(userInput);

                return input;
            }
        }


        public string PageStructure(int numForProductId)
        {
            using(var ctx = new Project0Context())
            {
                var productCtx = ctx.Product.FirstOrDefault(c => c.ProductGroupId == numForProductId);
                var queryForTypes = from types in ctx.Product
                                    where types.ProductGroupId == numForProductId
                                    select types;

                Console.WriteLine($"Welcome to the {productCtx.ProductName} Page");
                Console.WriteLine();
                Console.Write("Type ");

                foreach (var item in queryForTypes)
                {
                    Console.Write($"'{item.ProductName}' ");
                }
                Console.WriteLine();
                Console.WriteLine();

                foreach (var item2 in queryForTypes)
                {
                    Console.WriteLine($"{item2.ProductName} ${item2.Price}");
                }
                Console.WriteLine();
                Console.Write("Enter an option: ");
                string customerChoice = Console.ReadLine();

                return customerChoice;

            }
        }
    }
}
