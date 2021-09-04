using System;
using System.Collections.Generic;

#nullable disable

namespace DemoStoreDbContext.Models
{
	public partial class Customer
	{
		public Customer()
		{
			ItemizedOrders = new HashSet<ItemizedOrder>();
		}

		public int CustomerId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public virtual ICollection<ItemizedOrder> ItemizedOrders { get; set; }
	}
}
