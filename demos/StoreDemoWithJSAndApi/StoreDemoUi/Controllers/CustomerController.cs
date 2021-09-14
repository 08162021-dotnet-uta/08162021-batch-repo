﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _08162021batchDemoStore;
using DemoStoreBusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
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
		// GET: CustomerController
		public ActionResult Index()
		{
			return View();
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
		[HttpPut("customercreate/{id}")]
		public ActionResult Create(int id)
		{
			return View();
		}

		// POST: CustomerController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: CustomerController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: CustomerController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: CustomerController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: CustomerController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
