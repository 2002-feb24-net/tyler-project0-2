using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class Product
    {
        public Product()
        {
            Inventory = new HashSet<Inventory>();
            Orderline = new HashSet<Orderline>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int? Qauntity { get; set; }
        public int? ProductGroupId { get; set; }

        public virtual ProductGroup ProductGroup { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<Orderline> Orderline { get; set; }
    }
}
