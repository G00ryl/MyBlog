using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

		public Post Get(int id)
		{
			return _context.Posts.FirstOrDefault(r => r.Id == id);
		}

		public IEnumerable<Post> GetAll()
		{
			return _context.Posts.OrderBy(r => r.Id);
		}
	}
}
