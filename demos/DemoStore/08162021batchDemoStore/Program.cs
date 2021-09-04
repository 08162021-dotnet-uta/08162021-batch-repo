using System;
using System.Collections.Generic;
using DemoStoreDbContext.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using cust = DemoStoreDbContext.Models.Customer;

namespace _08162021batchDemoStore
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer c1 = new Customer();
			c1.Fname = "Markkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk";
			c1.Lname = "Jones";
			Customer c2 = new Customer("Jerry", "McGuire");

			System.Console.WriteLine($"The names are {c1.Fname} {c1.Lname}, {c2.Fname} {c2.Lname}");

			using (Demo_08162021batchContext context = new Demo_08162021batchContext())
			{
				var customers = context.Customers.FromSqlRaw<cust>("SELECT * FROM Customers WHERE FirstName = 'Ivana'").FirstOrDefault();// default is NULL
																																		 //var customers = context.Customers.ToList();
				if (customers != null)
				{
					Console.WriteLine($"The customer is {customers.FirstName} {customers.LastName}");
				}

				cust c3 = new cust();
				c3.FirstName = "Thwury";
				c3.LastName = "Thworthurus";

				context.Add(c3);
				context.SaveChanges();

				var thwury = context.Customers.FromSqlRaw<cust>("SELECT * FROM Customers WHERE FirstName = 'Thwury'").FirstOrDefault();// default is NULL

				if (thwury != null)
				{
					Console.WriteLine($"The customer is {thwury.FirstName} {thwury.LastName}");
				}


			}



		}
	}
}
