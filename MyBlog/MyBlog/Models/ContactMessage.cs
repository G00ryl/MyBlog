﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models
{
	public class ContactMessage
	{
		public int Id { get; set; }
		public string Nickname { get; set; }
		public string Email { get; set; }
		public string Description { get; set; }
	}
}
