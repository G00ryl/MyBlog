using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Models;

namespace MyBlog.Services
{
	interface ICommentData
	{
		Comment Add(Comment comment, IPostData postData);
	}
}
