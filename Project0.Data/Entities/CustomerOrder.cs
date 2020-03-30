using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class CustomerOrder
    {
        public CustomerOrder()
        {
            Orderline = new HashSet<Orderline>();
        }

        public int OrderId { get; set; }
        public int StoreId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal Total { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<Orderline> Orderline { get; set; }
    }
}
