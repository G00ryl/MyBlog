using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Models;
namespace MyBlog.ViewModels
{
	public class PostEditModel
	{
		
		[Required,MaxLength(50)]
		public string TitleOfPost { get; set; }
		public string DescriptionOfPost { get; set; }
	}
}
