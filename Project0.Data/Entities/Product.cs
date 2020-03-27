using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int ProductGroupId { get; set; }
        public int? OrderId { get; set; }
        public int? StoreId { get; set; }
        public int? Qauntity { get; set; }

        public virtual CustomerOrder Order { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Store Store { get; set; }
    }
}
