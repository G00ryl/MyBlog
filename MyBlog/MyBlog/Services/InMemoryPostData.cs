using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Models;

namespace MyBlog.Services
{
	public class InMemoryPostData :IPostData
	{
		public InMemoryPostData()
		{
			_posts = new List<Post>
			{
				new Post{ Id=1, TitleOfPost="How to be good programmer", DescriptionOfPost="I'm trying"},
				new Post{ Id = 2, TitleOfPost = "Step2, nonsence", DescriptionOfPost = "Nice try to be good"},
				new Post{ Id = 3, TitleOfPost = "Step3, nonsence", DescriptionOfPost = "Try to be good"}
			};
		}
		public IEnumerable<Post> GetAll()
		{
			return _posts.OrderBy(p => p.Id);
		}
		List<Post> _posts;
	}
}
