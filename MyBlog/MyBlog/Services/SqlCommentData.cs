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
		private IPostData _postData;

		public SqlCommentData(MyBlogDbContext context, IPostData postData)
		{
			_context = context;
			_postData = postData;
		}

		public Comment Add(Comment comment, int postId)
		{
			var post = _postData.Get(postId);
			comment.Post = post;

			_context.Comments.Add(comment);
			_context.SaveChanges();
			return comment;
		}
	}
}
