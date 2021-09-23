using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _08162021batchDemoStore;
using DemoStoreBusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StoreDemoUi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CustomerController : Controller
	{
		private readonly ICustomerRepository _customerrepo;
		private readonly ILogger<CustomerController> _logger;

		public CustomerController(ICustomerRepository cr, ILogger<CustomerController> logger)
		{
			_customerrepo = cr;
			_logger = logger;
		}

		// GET: CustomerController/Details/5
		[HttpGet("Customerlist")]
		public async Task<List<ViewModelCustomer>> Details()
		{
			// call the business layer method to return list of customers
			//List<ViewModelCustomer> customers = await 
			Task<List<ViewModelCustomer>> customers = _customerrepo.CustomerListAsync();
			//do stuff
			_logger.LogInformation("\n\nThere was a problem in the Customerlist method.\n\n");

			//do more stuff

			List<ViewModelCustomer> customers1 = await customers;
			return customers1;
		}

		// GET: CustomerController/Create - this is the route for conventional routing 
		// Attribute routing involves using attributes to define the path
		[HttpPost("register")]
		public async Task<ActionResult<ViewModelCustomer>> Create(ViewModelCustomer c)
		{
			if (!ModelState.IsValid) return BadRequest();

			//ViewModelCustomer c = new ViewModelCustomer() { Fname = fname, Lname = lname };
			//send fname and lname into a method of the business layer to check the Db fo that guy/gal;
			ViewModelCustomer c1 = await _customerrepo.RegisterCustomerAsync(c);
			if (c1 == null)
			{
				return NotFound();
			}

			return Created($"~customer/{c1.CustomerId}", c1);
		}

		/// <summary>
		/// This method takes a first name and last name and return a validted customer, if found
		/// otherwise returns NotFound().
		/// </summary>
		/// <param name="fname"></param>
		/// <param name="lname"></param>
		/// <returns></returns>
		[HttpGet("login/{fname}/{lname}")]
		public async Task<ActionResult<ViewModelCustomer>> Login(string fname, string lname)
		{
			if (!ModelState.IsValid) return BadRequest();

			ViewModelCustomer c = new ViewModelCustomer() { Fname = fname, Lname = lname };
			//send fname and lname into a method of the business layer to check the Db fo that guy/gal;
			ViewModelCustomer c1 = await _customerrepo.LoginCustomerAsync(c);
			if (c1 == null)
			{
				return NotFound();
			}

			return Ok(c1);
		}


	}//EoC
}// EoN
