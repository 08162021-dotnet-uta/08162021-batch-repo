using System;
using System.Collections.Generic;

#nullable disable

namespace DemoStoreDbContext.Models
{
    public partial class Product
    {
        public Product()
        {
            ItemizedOrders = new HashSet<ItemizedOrder>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }

        public virtual ICollection<ItemizedOrder> ItemizedOrders { get; set; }
    }
}
