using Project0.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Data
{
    class OrderHelp
    {
        public void CustomerOrder()
        {
            using (var ctx = new Project0Context())
            {
                foreach (var item in ctx.Product)
                {
                    Console.WriteLine($"{item.ProductId}. {item.ProductName}");
                    Console.WriteLine();
                }
            }
        }
    }
}
