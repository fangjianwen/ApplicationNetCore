using Bll;
using Dal;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApplicationNetCore.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUserSubmit(Users model)
        {






            //bool result = BaseBll.Add(model);
            Users user = BaseBll.GetModel<Users>(p => p.UserId == 1);
            user.UserName += new Random().Next(0,100);
            bool result = BaseBll.Update(user);
            if (result)
            {
                ViewBag.Msg = "创建用户成功";
            }
            else
            {
                ViewBag.Msg = "创建用户失败";
            }
            return View("AddUser");
        }
    }
}
