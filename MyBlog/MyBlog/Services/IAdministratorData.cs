using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Models;
using MyBlog.ViewModels;

namespace MyBlog.Services
{
    public interface IAdministratorData
    {
        Administrator Login(LoginViewModel model);
    }
}
