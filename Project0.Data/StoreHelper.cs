using Project0.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project0.Data
{
    public class StoreHelper
    {
        public void UserPicksStore()
        {
            using (var ctx = new Project0Context())
            {
                Console.WriteLine("List of stores");

                foreach (var item in ctx.Store)
                {
                    Console.WriteLine($"{item.City}");
                }
                Console.WriteLine();
                Console.Write("Select a store by the name of the city: ");
                string selectStore = Console.ReadLine();

                var returnStore = ctx.Store.FirstOrDefault(b => b.City == selectStore);

                if(returnStore == null)
                {
                    Console.WriteLine("That is not a valid choice");
                    UserPicksStore();
                }
                else
                {
                    Console.WriteLine($"You have selected store {returnStore.Id}");
                }
            }

        }
    }
}
