using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.Models
{
	public class Post
	{
		public int Id { get; set; }
		public string TitleOfPost { get; set; }
		public string DescriptionOfPost { get; set; }
		public string Tags { get; set; }
		public List<Comment> Comments { get; set; }
	}
}
