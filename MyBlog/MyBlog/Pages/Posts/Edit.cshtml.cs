using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBlog.Models;
using MyBlog.Services;

namespace MyBlog.Pages.Posts
{
    public class EditModel : PageModel
    {
        private IPostData _postData;
        [BindProperty]
        public Post Post{ get; set; }
        public EditModel(IPostData postData)
        {
            _postData = postData;
        }

        public IActionResult OnGet(int id)
        {
            Post = _postData.Get(id);
            if(Post == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                _postData.Update(Post);
                return RedirectToAction("Details", "Home", new { id =Post.Id});
            }
            return Page();
        }
    }
}