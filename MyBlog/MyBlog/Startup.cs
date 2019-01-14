using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyBlog.Services;
using MyBlog.Models;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data;

namespace MyBlog
{
	public class Startup
	{
		private IConfiguration _configuration;

		public Startup(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<MyBlogDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("MyBlog")));
			services.AddScoped<IPostData, SqlPostData>();
			services.AddScoped<ICommentData, SqlCommentData>();
			services.AddScoped<IContactMessageData, ContactMessageData>();
			services.AddMvc();
			services.AddDistributedMemoryCache();

			services.AddSession(options =>
			{
				options.Cookie.Name = ".AdventureWorks.Session";
				options.IdleTimeout = TimeSpan.FromSeconds(10);
			});

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app,
							IHostingEnvironment env,
							ILogger<Startup> logger)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStaticFiles();
			app.UseMvc(configureRoutes);
			app.UseSession();
			

			app.Run(async (context) =>
			{

				context.Response.ContentType = "text/plain";
				await context.Response.WriteAsync($"Not found");
			});
		}

		private void configureRoutes(IRouteBuilder routeBuilder)
		{
			// /Home/Index

			routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
		}
	}
}
