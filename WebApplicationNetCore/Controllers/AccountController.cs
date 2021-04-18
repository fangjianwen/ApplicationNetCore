using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApplicationNetCore.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginPost(string userName, string password)
        {
            if (userName != "user" && userName != "admin")
            {
                ViewBag.ErrorMsg = "用户名或密码错误";
                return View("Login");
            }
            if (password != "123456")
            {
                ViewBag.ErrorMsg = "用户名或密码错误";
                return View("Login");
            }

            //一个claim 把它想作一对key和value。 new Claim(Key, Value),
            var claims = new List<Claim>()
                {
                 new Claim(ClaimTypes.Name, userName),
                 new Claim(ClaimTypes.NameIdentifier, "1"),
                  new Claim(ClaimTypes.Role, userName)
                };

            //ClaimsIdentity 把它想作一个身份证   
            var indentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            //ClaimsPrincipal表示一个人，把身份证给这个人
            var principal = new ClaimsPrincipal(indentity);

            //登录，写入cookie 把这个人传进去
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectToAction("Index", "Home");


        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
