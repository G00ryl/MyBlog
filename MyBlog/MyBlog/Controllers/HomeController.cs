using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using MyBlog.Services;
using MyBlog.ViewModels;
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
			var model = new HomeIndexViewModel();
			model.Posts = _postData.GetAll();
			return View(model);
		}
		public IActionResult Details(int id)
		{
			var model = _postData.Get(id);
			if (model == null)
			{
				return RedirectToAction(nameof(Index));
			}
			return View(model);
		}
		public IActionResult Create()
		{
			return View();
		}

	}
}
