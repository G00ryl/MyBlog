using MyBlog.Data;
using MyBlog.Models;
using MyBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Services
{
	public class ContactMessageData : IContactMessageData
	{
		public readonly  MyBlogDbContext _context;

		public ContactMessageData(MyBlogDbContext context)
		{
			_context = context;
		}
		public ContactMessage AddContactMessage(ContactMessage message)
		{
			 _context.Messege.Add(message);
			 _context.SaveChanges();
			return message;
		}
	}
}



