using Microsoft.EntityFrameworkCore;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Data;
namespace MyBlog.Data
{
	public class MyBlogDbContext :DbContext
	{
		public MyBlogDbContext(DbContextOptions options)
			: base(options)
		{

		}
		public DbSet <Post> Posts { get; set; }


	}
}
