using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Data;
using MyBlog.Models;

namespace MyBlog.Services
{
	public class SqlCommentData : ICommentData
	{
		private MyBlogDbContext _context;

		public SqlCommentData(MyBlogDbContext context)
		{
			_context = context;
		}
		public Comment Add(Comment comment, IPostData postData)
		{
			_context.Comments.Add(comment);
			_context.SaveChanges();
			return comment;
		}
	}
}
