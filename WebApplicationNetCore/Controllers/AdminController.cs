using Bll;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
            bool result = BaseBll.Add(model);
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
