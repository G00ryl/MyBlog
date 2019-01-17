using System;
using System.Collections.Generic;
using System.Linq;
using MyBlog.Data;
using MyBlog.Models;
using MyBlog.ViewModels;

namespace MyBlog.Services
{
    public class SqlAdministratorData : IAdministratorData
    {
        private readonly MyBlogDbContext _context;

        public SqlAdministratorData(MyBlogDbContext context)
        {
            _context = context;
        }

        public Administrator Login(LoginViewModel model)
        {
            if (string.IsNullOrEmpty(model.Nick) || string.IsNullOrEmpty(model.Password))
                throw new Exception("Credentials can't be empty.");

            var admin = _context.Admins.SingleOrDefault(x => x.Login.ToLowerInvariant() == model.Nick.ToLowerInvariant() && x.Password == model.Password);

            if (admin == null)
                throw new Exception("Wrong credentials.");

            return admin;
        }
		public Administrator Add(Administrator admin)
		{
			_context.Admins.Add(admin);
			_context.SaveChanges();
			return admin;
		}
	}
}
