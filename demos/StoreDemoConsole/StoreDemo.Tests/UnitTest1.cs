using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _08162021batchDemoStore;
using DemoStoreBusinessLayer;
using DemoStoreBusinessLayer.Interfaces;
using DemoStoreDbContext.Models;
using Microsoft.EntityFrameworkCore;
using StoreDemoUi.Controllers;
using Xunit;

namespace StoreDemo.Tests
{
	public class UnitTest1
	{
		public DbContextOptions<Demo_08162021batchContext> options { get; set; } = new DbContextOptionsBuilder<Demo_08162021batchContext>()
			.UseInMemoryDatabase(databaseName: "TestDb")
			.Options;

		[Fact]
		public async Task Test1()
		{
			using (Demo_08162021batchContext _context = new Demo_08162021batchContext(options))
			{
				// ARRANGE
				// create the foundation of the test.
				_context.Database.EnsureDeleted();// delete any Db fro a previous test
				_context.Database.EnsureCreated();// create anew the Db... you will need ot seed it again.

				Customer c1 = new Customer() { FirstName = "Ben", LastName = "Franklin" };
				Customer c2 = new Customer() { FirstName = "Sven", LastName = "Franklin" };
				Customer c3 = new Customer() { FirstName = "Chen", LastName = "Franklin" };

				_context.Customers.Add(c1);
				_context.Customers.Add(c2);
				_context.Customers.Add(c3);
				_context.SaveChanges();

				CustomerRepository cr = new CustomerRepository(_context);

				// ACT
				// act on that foundation.. meaning.. input or use the M.U.T.
				//Customer c1 = _context.Customers.Where(cust => cust.FirstName == "Ben" && cust.LastName == "Franklin").FirstOrDefault();

				// instead of using the context directly, I'pm ogong to use the custoemrrepoitory wiht the mocked Db adn the fake data
				List<ViewModelCustomer> result = await cr.CustomerListAsync();

				// ASSERT
				Assert.Equal(3, result.Count);
				Assert.True(result.Count == 3);
				Assert.True(result[2].Fname == "Chen");
				Assert.Contains("en", result[0].Fname);
			}
		}

		[Fact]
		public async Task CustomerListReturnsCorrectList()
		{
			// ARRANGE
			ICustomerRepository repoMock = new CustomerRepositoryMock();
			CustomerController cc = new CustomerController(repoMock);

			// ACT
			List<ViewModelCustomer> result = await cc.Details();

			// ASSERT
			Assert.Equal("Leche", result[0].Fname);
		}

	}
}
