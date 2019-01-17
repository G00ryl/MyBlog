using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        private IAdministratorData _administratorData;

		public HomeController(IPostData postData, ICommentData commentData, IContactMessageData contactMessageData,
            IAdministratorData administratorData)
		{
			_postData = postData;
			_commentData = commentData;
			_contactMessageData = contactMessageData;
            _administratorData = administratorData;
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
		public IActionResult Login(LoginViewModel model)
		{
            try
            {
                var admin = _administratorData.Login(model);

                HttpContext.Session.SetString("Login", admin.Login);
                HttpContext.Session.SetString("Id", admin.id.ToString());

                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.Clear();
                return View();
            }
        }
		[HttpGet]
		public IActionResult Search(string query)
		{
			var posts = _postData.GetAllPosts(query);

			return View("SearchPost", posts);
		}
		[HttpGet]
		public IActionResult AdminPanel()
		{
			return View();
		}
		[HttpGet]
		public IActionResult ContactMessages()
		{
			var model = new ContactMessagesViewModelcs();
			model.Message = _contactMessageData.GetAll();
			return View(model);
		}
		[HttpGet]
		public IActionResult NewAdmin()
		{
			return View();
		}
	}
}
