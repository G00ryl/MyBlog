using Microsoft.EntityFrameworkCore;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Data;
namespace MyBlog.Data
{
	public class MyBlogDbContext : DbContext
	{
		public DbSet<Post> Posts { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Administrator> Admins { get; set; }
		public DbSet<ContactMessage> Messege { get; set; }

		public MyBlogDbContext(DbContextOptions options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			foreach (var relationship in modelBuilder.Model.GetEntityTypes()
					.SelectMany(e => e.GetForeignKeys()))
			{
				relationship.DeleteBehavior = DeleteBehavior.Restrict;
			}

			modelBuilder.Entity<Post>()
					.HasMany(x => x.Comments)
					.WithOne(y => y.Post)
					.IsRequired(false);
		}
	}
}
