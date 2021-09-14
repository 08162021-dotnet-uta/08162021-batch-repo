using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08162021batchDemoStore;
using DemoStoreBusinessLayer.Interfaces;
using DemoStoreDbContext.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoStoreBusinessLayer
{
	public class CustomerRepository : ICustomerRepository
	{
		// Step1 of DI - create  privatre instance of the dependency
		private readonly Demo_08162021batchContext _context;

		// step 2 of DI - call for an in stance from the DI system in your constructor.
		public CustomerRepository(Demo_08162021batchContext context)
		{
			_context = context;
		}

		/// <summary>
		/// This method will take a ViewModelVustomer object and return the ViewModelCustomer
		/// if found in the Db.
		/// Null if not found.
		/// </summary>
		/// <returns></returns>
		public async Task<ViewModelCustomer> LoginCustomerAsync(ViewModelCustomer vmc)
		{
			Customer c1 = ModelMapper.ViewModelCustomerToCustomer(vmc);

			Customer c2 = await _context.Customers.FromSqlRaw<Customer>("SELECT * FROM Customers WHERE FirstName = {0} and LastName = {1}", c1.FirstName, c1.LastName).FirstOrDefaultAsync();// default is NULL

			if (c2 == null) return null;

			ViewModelCustomer c3 = ModelMapper.CustomerToViewModelCustomer(c2);
			return c3;
		}

		public async Task<ViewModelCustomer> RegisterCustomerAsync(ViewModelCustomer vmc)
		{
			Customer c1 = ModelMapper.ViewModelCustomerToCustomer(vmc);

			int c2 = await _context.Database.ExecuteSqlRawAsync("INSERT INTO Customers (FirstName, LastName) VALUES ({0},{1})", c1.FirstName, c1.LastName);// default is NULL

			if (c2 != 1) return null;

			//Customer c3 = _context.Customers.FromSqlRaw<Customer>("SELECT * FROM Customers WHERE FirstName = {0} and LastName = {1}", c1.FirstName, c1.LastName).FirstOrDefault();// default is NULL

			//if (c2 == null) return null;

			//ViewModelCustomer c4 = ModelMapper.CustomerToViewModelCustomer(c3);
			//return c4;

			return await LoginCustomerAsync(vmc);
		}

		/// <summary>
		/// This method getss a list of all the products or a single product given an arg.
		/// </summary>
		/// <returns></returns>
		public async Task<List<ViewModelProduct>> ProductsAsync(int prodId = -1)
		{
			List<ViewModelProduct> viewmodelproducts = new List<ViewModelProduct>();
			// get all the products
			if (prodId == -1)
			{
				List<Product> products = await _context.Products.FromSqlRaw<Product>("Select * FROM Products").ToListAsync();
				// convert to ViewMOdelProduct
				foreach (Product p in products)
				{
					viewmodelproducts.Add(ModelMapper.ProductToViewModelProduct(p));
				}
				return viewmodelproducts;
			}
			else
			{
				List<Product> products = await _context.Products.FromSqlRaw<Product>($"Select TOP 1 FROM Products WHERE ProductId = {prodId}").ToListAsync();
				// convert to ViewMOdelProduct
				foreach (Product p in products)
				{
					viewmodelproducts.Add(ModelMapper.ProductToViewModelProduct(p));
				}
				return viewmodelproducts;
			}
		}

		public async Task<List<ViewModelCustomer>> CustomerListAsync()
		{
			List<Customer> customers = await _context.Customers.FromSqlRaw<Customer>("Select * FROM Customers").ToListAsync();
			List<ViewModelCustomer> vmc = new List<ViewModelCustomer>();
			foreach (Customer c in customers)
			{
				vmc.Add(ModelMapper.CustomerToViewModelCustomer(c));
			}
			return vmc;
		}



	}// EoC
}// EoN
