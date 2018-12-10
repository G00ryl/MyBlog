using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models
{
	public class Comment
	{
		public string DescriptionOfComment { get; set; }
		public string NicknameOfCommenter { get; set; }
		public Post Post { get; set; }
	}
}
