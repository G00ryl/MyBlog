using MyBlog.Models;
using MyBlog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Services
{
	public interface IContactMessageData
	{
		ContactMessage AddContactMessage(ContactMessage message);
		IEnumerable<ContactMessage> GetAll();
	}
}
