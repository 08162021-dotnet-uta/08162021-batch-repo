using System;
using System.Collections.Generic;
//using DemoStoreDbContext.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DemoStoreDbContext.Models;
using DemoStoreBusinessLayer;

namespace _08162021batchDemoStore
{
	class Program
	{
		//static readonly HttpClient client = new HttpClient();

		static async Task Main(string[] args)
		{
			#region this is some of the setup code.
			//ViewModelCustomer c1 = new ViewModelCustomer();
			//c1.Fname = "Markkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk";
			//c1.Lname = "Jones";
			//ViewModelCustomer c2 = new ViewModelCustomer("Jerry", "McGuire");

			//System.Console.WriteLine($"The names are {c1.Fname} {c1.Lname}, {c2.Fname} {c2.Lname}");
			#endregion

			#region this is some of the setup code.
			//var customers = context.Customers.FromSqlRaw<cust>("SELECT * FROM Customers WHERE FirstName = 'Ivana'").FirstOrDefault();// default is NULL
			//																														 //var customers = context.Customers.ToList();
			//if (customers != null)
			//{
			//	Console.WriteLine($"The customer is {customers.FirstName} {customers.LastName}");
			//}

			//cust c3 = new cust();
			//c3.FirstName = "Thwury";
			//c3.LastName = "Thworthurus";

			//context.Add(c3);
			//context.SaveChanges();

			//var thwury = context.Customers.FromSqlRaw<cust>("SELECT * FROM Customers WHERE FirstName = 'Thwury'").FirstOrDefault();// default is NULL

			//if (thwury != null)
			//{
			//	Console.WriteLine($"The customer is {thwury.FirstName} {thwury.LastName}");
			//}
			#endregion


			//try
			//{
			//	var response = await client.GetAsync("http://api.icndb.com/jokes/random");
			//	response.EnsureSuccessStatusCode();
			//	string resBody = await response.Content.ReadAsStringAsync();
			//	System.Console.WriteLine(resBody);

			//}
			//catch (HttpRequestException e)
			//{
			//	Console.WriteLine($"Message: {e.Message}");
			//}


			using (Demo_08162021batchContext _context = new Demo_08162021batchContext())
			{
				List<Customer> listofcustomers = _context.Customers.ToList();
				foreach (Customer c in listofcustomers)
				{
					Console.WriteLine($"{c.FirstName} {c.LastName}");
				}

				Console.WriteLine("Hello, User. Would you like to log in or are you a new customer?");
				Console.WriteLine("Select a option!\n\t1 - Log in\n\t2 - Register");


				// TODO TODAY
				//1. register a new user (username and password, fname, lname)
				string userinput = Console.ReadLine();
				if (userinput == "1")
				{
					ViewModelCustomer c = new ViewModelCustomer();

					// give a login option
					Console.WriteLine($" Great!. Please enter your first name");
					c.Fname = Console.ReadLine();
					Console.WriteLine($"Please enter your last name");
					c.Lname = Console.ReadLine();

					CustomerRepository customerRepo = new CustomerRepository();
					ViewModelCustomer vmc = customerRepo.LoginCustomer(c);

					if (vmc == null)
					{
						userinput = "2";
					}
					else
					{
						Console.WriteLine($"The returned customer is {vmc.Fname} {vmc.Lname}");
					}



				}
				if (userinput == "2")
				{
					// give the register option
					ViewModelCustomer c = new ViewModelCustomer();

					// give a login option
					Console.WriteLine($" To register, please enter your first name");
					c.Fname = Console.ReadLine();
					Console.WriteLine($"Please enter your last name");
					c.Lname = Console.ReadLine();

					CustomerRepository customerRepo = new CustomerRepository();
					ViewModelCustomer vmc = customerRepo.RegisterCustomer(c);

					if (vmc == null)
					{
						Console.WriteLine("There was a problem with the register method");
					}
					else
					{
						Console.WriteLine($"The REGISTERED customer is {vmc.Fname} {vmc.Lname}");
					}
				}
				//2. get the list of products

				//3. choose some products

				//4. complete an order.





			}// End of Using statement
		}// End of main
	}// end of class
}// end of namespace 
