using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.ViewModels
{
	public class DetailPostViewModel
	{
		public Post Post { get; set; }
		public string CommentText { get; set; }
		public string CommentNick { get; set; }
	}
}
