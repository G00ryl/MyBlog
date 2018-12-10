using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using MyBlog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MyBlog.Controllers
{
	public class HomeController :Controller
	{
		private IPostData _postData;
		public HomeController(IPostData postData)
		{
			_postData = postData;
		}
		public IActionResult Index()
		{
			var model = _postData.GetAll();
			return View(model);
		}
	}
}
