using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08162021batchDemoStore;
using DemoStoreDbContext.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoStoreBusinessLayer
{
	public class CustomerRepository
	{

		public Demo_08162021batchContext _context = new Demo_08162021batchContext();

		/// <summary>
		/// This method will take a ViewModelVustomer object and return the ViewModelCustomer
		/// if found in the Db.
		/// Null if not found.
		/// </summary>
		/// <returns></returns>
		public ViewModelCustomer LoginCustomer(ViewModelCustomer vmc)
		{
			Customer c1 = ModelMapper.ViewModelCustomerToCustomer(vmc);

			Customer c2 = _context.Customers.FromSqlRaw<Customer>("SELECT * FROM Customers WHERE FirstName = {0} and LastName = {1}", c1.FirstName, c1.LastName).FirstOrDefault();// default is NULL

			if (c2 == null) return null;

			ViewModelCustomer c3 = ModelMapper.CustomerToViewModelCustomer(c2);
			return c3;
		}

		public ViewModelCustomer RegisterCustomer(ViewModelCustomer vmc)
		{
			Customer c1 = ModelMapper.ViewModelCustomerToCustomer(vmc);

			int c2 = _context.Database.ExecuteSqlRaw("INSERT INTO Customers (FirstName, LastName) VALUES ({0},{1})", c1.FirstName, c1.LastName);// default is NULL

			if (c2 != 1) return null;

			//Customer c3 = _context.Customers.FromSqlRaw<Customer>("SELECT * FROM Customers WHERE FirstName = {0} and LastName = {1}", c1.FirstName, c1.LastName).FirstOrDefault();// default is NULL

			//if (c2 == null) return null;

			//ViewModelCustomer c4 = ModelMapper.CustomerToViewModelCustomer(c3);
			//return c4;

			return LoginCustomer(vmc);
		}

	}
}
