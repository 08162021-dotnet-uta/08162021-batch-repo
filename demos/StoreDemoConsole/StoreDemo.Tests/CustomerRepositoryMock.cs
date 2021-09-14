using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08162021batchDemoStore;
using DemoStoreBusinessLayer.Interfaces;

namespace StoreDemo.Tests
{
	class CustomerRepositoryMock : ICustomerRepository
	{
		public Task<List<ViewModelCustomer>> CustomerListAsync()
		{
			List<ViewModelCustomer> vmcMock = new List<ViewModelCustomer>();
			vmcMock.Add(new ViewModelCustomer() { Fname = "Leche", Lname = "Milk" });
			vmcMock.Add(new ViewModelCustomer() { Fname = "Cerveza", Lname = "Brrr" });
			vmcMock.Add(new ViewModelCustomer() { Fname = "Voludo", Lname = "Idiot" });
			vmcMock.Add(new ViewModelCustomer() { Fname = "Ethcuela", Lname = "School" });
			return Task.FromResult(vmcMock);
		}

		public Task<ViewModelCustomer> LoginCustomerAsync(ViewModelCustomer vmc)
		{
			throw new NotImplementedException();
		}

		public Task<List<ViewModelProduct>> ProductsAsync(int prodId = -1)
		{
			throw new NotImplementedException();
		}

		public Task<ViewModelCustomer> RegisterCustomerAsync(ViewModelCustomer vmc)
		{
			throw new NotImplementedException();
		}
	}
}
