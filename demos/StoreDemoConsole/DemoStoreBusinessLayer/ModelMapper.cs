using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08162021batchDemoStore;
using DemoStoreBusinessLayer.Interfaces;

namespace DemoStoreBusinessLayer
{
	public class ModelMapper : IModelMapper
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
		/// This method takes a ViewModelCustomer and returns the mapping to a Customer
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

		/// <summary>
		/// This method takes a ViewModelProduct and returns the mapping to a Product
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
		public static Product ViewModelProductToProduct(ViewModelProduct c)
		{
			Product c1 = new Product();
			c1.ProductId = c.ProductId;
			c1.ProductName = c.ProductName;
			c1.ProductPrice = c.ProductPrice;
			return c1;
		}

		/// <summary>
		/// This method takes a Product and returns the mapping to a ViewModelProduct
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
		public static ViewModelProduct ProductToViewModelProduct(Product c)
		{
			ViewModelProduct c1 = new ViewModelProduct();
			c1.ProductId = c.ProductId;
			c1.ProductName = c.ProductName;
			c1.ProductPrice = c.ProductPrice;
			return c1;
		}

	}
}
