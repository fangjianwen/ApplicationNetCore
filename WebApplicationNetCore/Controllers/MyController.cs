using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationNetCore.Controllers
{
    [Route("MyRoute/{controller}/{action}/{id?}")]
    public class MyController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
