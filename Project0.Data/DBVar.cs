using Project0.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Data
{
    public class DBVar
    {
        public static readonly Project0Context ctx = new Project0Context();
        public static Store store1 = new Store();
        public static ProductGroup pg1 = new ProductGroup();

        public static void ExitBack()
        {
            Console.WriteLine("Press 0 to Exit");
            Console.WriteLine("Press 8 to go back");
            Console.WriteLine();
        }
    }
}
