using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data;
using MyBlog.Models;


namespace MyBlog.Services
{
	public class SqlPostData : IPostData
	{
		private MyBlogDbContext _context;

		public SqlPostData(MyBlogDbContext context)
		{
			_context = context;
		}
		public Post Add(Post post)
		{
			_context.Posts.Add(post);
			_context.SaveChanges();
			return post;
		}

		public Post Get(int id) => _context.Posts.Include(r => r.Comments).FirstOrDefault(r => r.Id == id);
	

		public IEnumerable<Post> GetAll()
		{
			return _context.Posts.OrderByDescending(r => r.Id);
		}

		public Post Update(Post post)
		{
			_context.Attach(post).State = EntityState.Modified;
			_context.SaveChanges();
			return post;
		}
		
	}
}
