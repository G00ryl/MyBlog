﻿using Microsoft.AspNetCore.Authorization;
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
	public class HomeController : Controller
	{
		private IPostData _postData;
		private ICommentData _commentData;
		private IContactMessageData _contactMessageData;

		public HomeController(IPostData postData, ICommentData commentData, IContactMessageData contactMessageData)
		{
			_postData = postData;
			_commentData = commentData;
			_contactMessageData = contactMessageData;
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
					DescriptionOfPost = model.DescriptionOfPost,
					Tags = model.Tags
				};


				newPost = _postData.Add(newPost);

				return RedirectToAction(nameof(Details), new { id = newPost.Id });
			}
			else
			{
				return View();
			}
		}

		[HttpGet]
		public IActionResult Contact()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Contact(ContactMessageViewModel model)
		{
			if (ModelState.IsValid)
			{
				var newContactMessage = new ContactMessage
				{
					Nickname = model.Nickname,
					Email = model.Email,
					Description = model.Description
				};


				newContactMessage = _contactMessageData.AddContactMessage(newContactMessage);

				return RedirectToAction(nameof(Index));
			}
			else
			{
				return View();
			}
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login(HomeIndexViewModel model)
		{
			return RedirectToAction(nameof(Index));
		}

	}
}
