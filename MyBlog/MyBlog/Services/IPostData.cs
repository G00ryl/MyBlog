using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Models;

namespace MyBlog.Services
{
	public interface IPostData
	{
		IEnumerable<Post> GetAll();
		Post Get(int id);
		Post Add(Post post);
		Post Update(Post post);
		IEnumerable<Post> GetAllPosts(string category);
	}
}
