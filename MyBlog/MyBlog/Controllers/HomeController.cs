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
		private ICommentData _commentData;

		public HomeController(IPostData postData, ICommentData commentData)
		{
			_postData = postData;
			_commentData = commentData;
		}

		public IActionResult Index()
		{
			var model = new HomeIndexViewModel();
			model.Posts = _postData.GetAll();
			return View(model);
		}

		[HttpGet]
		public IActionResult Details(int id)
		{
			var model = new DetailPostViewModel { Post = _postData.Get(id) };
			if (model == null)
			{
				return RedirectToAction(nameof(Index));
			}
			return View(model);
		}

		[HttpPost]
		public IActionResult Details(int id, DetailPostViewModel model)
		{
			if (!ModelState.IsValid)
			{
				RedirectToAction("Details", "Home", id);
			}

			try
			{
				var comment = new Comment
				{
					DescriptionOfComment = model.CommentText,
					NicknameOfCommenter = model.CommentNick
				};

				comment = _commentData.Add(comment, id);
				return RedirectToAction("Details", "Home", id);
			}
			catch (Exception)
			{
				return RedirectToAction("Index", "Home");
			}
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(PostEditModel model)
		{
			if (ModelState.IsValid)
			{
				var newPost = new Post
				{
					TitleOfPost = model.TitleOfPost,
					DescriptionOfPost = model.DescriptionOfPost
				};


				newPost = _postData.Add(newPost);

				return RedirectToAction(nameof(Details), new { id = newPost.Id });
			}
			else
			{
				return View();
			}
		}

		public IActionResult Contact()
		{
			return View();
		}
	}
}
