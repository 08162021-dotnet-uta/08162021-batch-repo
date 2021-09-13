using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08162021batchDemoStore;

namespace DemoStoreBusinessLayer
{
	public static class ModelMapper
	{
		/// <summary>
		/// THis method takes a Customer and returns the mapping to a ViewModelCustomer
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
		public static ViewModelCustomer CustomerToViewModelCustomer(Customer c)
		{
			ViewModelCustomer c1 = new ViewModelCustomer();
			c1.Fname = c.FirstName;
			c1.Lname = c.LastName;

			return c1;
		}

		/// <summary>
		/// THis method takes a ViewModelCustomer and returns the mapping to a Customer
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
		public static Customer ViewModelCustomerToCustomer(ViewModelCustomer c)
		{
			Customer c1 = new Customer();
			c1.FirstName = c.Fname;
			c1.LastName = c.Lname;
			return c1;
		}

	}
}
