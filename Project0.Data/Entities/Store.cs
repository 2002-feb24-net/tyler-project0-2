using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class Store : DBVar, IOutPut
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zip { get; set; }

        public void DisplayDB()
        {
            Console.WriteLine($"We have a number of different stores in Texas");

            Console.WriteLine();
            foreach (var item in ctx.Store)
            {
                Console.WriteLine($"{item.City}");
            }

            Console.WriteLine("Select a store please");
        }
    }
}
