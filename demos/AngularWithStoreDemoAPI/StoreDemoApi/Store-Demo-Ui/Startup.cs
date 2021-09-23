using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoStoreBusinessLayer;
using DemoStoreBusinessLayer.Interfaces;
using DemoStoreDbContext.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace Store_Demo_Ui
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			services.AddControllers();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "Store_Demo_Ui", Version = "v1" });
			});

			services.AddDbContext<Demo_08162021batchContext>(options =>
			{
				//if db options is already configured, done do anything..
				// otherwise use the Connection string I have in secrets.json
				if (!options.IsConfigured)
				{
					options.UseSqlServer(Configuration.GetConnectionString("AzureDb"));
				}
			});

			//registering classes with the DI system.
			services.AddScoped<ICustomerRepository, CustomerRepository>();
			services.AddScoped<IModelMapper, ModelMapper>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Store_Demo_Ui v1"));
			}

			app.UseDeveloperExceptionPage();

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
