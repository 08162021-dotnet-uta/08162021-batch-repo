using System;
using System.Collections.Generic;

#nullable disable

namespace DemoStoreDbContext.Models
{
    public partial class ItemizedOrder
    {
        public Guid ItemizedId { get; set; }
        public Guid OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
