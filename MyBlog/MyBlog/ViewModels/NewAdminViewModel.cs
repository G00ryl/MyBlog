using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Models;


namespace MyBlog.ViewModels
{
	public class NewAdminViewModel
	{
		[Required, MaxLength(50)]
		public string  Login { get; set; }
		[Required, MaxLength(10000)]
		public string Password { get; set; }
		
	}
}
