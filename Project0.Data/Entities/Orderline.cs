using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class Orderline
    {
        public int ProductId { get; set; }
        public int? OrderId { get; set; }
        public int? Quantity { get; set; }
        public int OrderlineId { get; set; }

        public virtual CustomerOrder Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
