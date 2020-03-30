using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class Store
    {
        public Store()
        {
            CustomerOrder = new HashSet<CustomerOrder>();
            Inventory = new HashSet<Inventory>();
        }

        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zip { get; set; }

        public virtual ICollection<CustomerOrder> CustomerOrder { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}
