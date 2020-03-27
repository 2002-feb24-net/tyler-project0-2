using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class CustomerOrder
    {
        public CustomerOrder()
        {
            Product = new HashSet<Product>();
        }

        public int OrderId { get; set; }
        public int StoreId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
