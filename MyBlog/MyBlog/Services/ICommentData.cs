using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Models;

namespace MyBlog.Services
{
	public interface ICommentData
	{
		Comment Add(Comment comment, int postId);
	}
}
