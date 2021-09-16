using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _08162021batchDemoStore;
using DemoStoreBusinessLayer;
using DemoStoreBusinessLayer.Interfaces;
using DemoStoreDbContext.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
				// create a new InMemory Db to use for this test.
				_context.Database.EnsureDeleted();// delete any Db from a previous test
				_context.Database.EnsureCreated();// create a new Db... you will need to seed it again.

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
			// create a mock of teh CustomerRepository dependency
			ICustomerRepository repoMock = new CustomerRepositoryMock();

			// grab the logger service
			var serviceProvider = new ServiceCollection().AddLogging().BuildServiceProvider();
			var factory = serviceProvider.GetService<ILoggerFactory>();
			var _logger = factory.CreateLogger<CustomerController>();

			//send both the mock and service into the controller to instantiate it.
			CustomerController cc = new CustomerController(repoMock, _logger);

			// ACT
			List<ViewModelCustomer> result = await cc.Details();

			// ASSERT
			Assert.Equal("Leche", result[0].Fname);
		}

		//[Fact]
		//public async Task LoginCustomerAsyncReturnsTheLoggedInUser()
		//{
		//	using (Demo_08162021batchContext _context = new Demo_08162021batchContext(options))
		//	{
		//		// ARRANGE
		//		// create the foundation of the test.
		//		// create a new InMemory Db to use for this test.
		//		_context.Database.EnsureDeleted();// delete any Db from a previous test
		//		_context.Database.EnsureCreated();// create a new Db... you will need to seed it again.

		//		// fill the Db with some customers
		//		Customer c1 = new Customer() { FirstName = "Ben", LastName = "Franklin" };
		//		Customer c2 = new Customer() { FirstName = "Sven", LastName = "Franklin" };
		//		Customer c3 = new Customer() { FirstName = "Chen", LastName = "Franklin" };
		//		ViewModelCustomer c4 = new ViewModelCustomer() { Fname = "Ben", Lname = "Franklin" };
		//		_context.Customers.Add(c1);
		//		_context.Customers.Add(c2);
		//		_context.Customers.Add(c3);
		//		_context.SaveChanges();

		//		CustomerRepository cr = new CustomerRepository(_context);

		//		// ACT
		//		// instead of using the context directly, I'm going to use the customerRepository that's using the mocked Db and data
		//		ViewModelCustomer result = await cr.LoginCustomerAsync(c4);

		//		// ASSERT
		//		Assert.True(result.Lname == "Franklin" && result.Fname == "Ben");
		//	}
		//}


	}// EoC
}// EoN
