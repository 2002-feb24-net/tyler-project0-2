﻿using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class ProductGroup
    {
        public ProductGroup()
        {
            Product = new HashSet<Product>();
        }

        public int ProductGroupId { get; set; }
        public string ProductName { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
