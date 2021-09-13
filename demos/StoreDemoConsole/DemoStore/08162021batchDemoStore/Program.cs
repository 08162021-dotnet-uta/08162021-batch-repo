using System;
using System.Collections.Generic;
//using DemoStoreDbContext.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace _08162021batchDemoStore
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();

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

            Console.WriteLine("Hello, User. Would you like to log in or are you a ndew customer?");
            Console.WriteLine("Select a option!\n\t1 - Log in\n\t2 - Register");

            try
            {
                var response = await client.GetAsync("http://api.icndb.com/jokes/random");
                response.EnsureSuccessStatusCode();
                string resBody = await response.Content.ReadAsStringAsync();
                System.Console.WriteLine(resBody);

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Message: {e.Message}");
            }





        }
    }
}
