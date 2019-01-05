using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.ViewModels
{
	public class HomeIndexViewModel
	{
		public IEnumerable<Post> Posts { get; set; }
	}
}
