using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldJNodz.Controllers
{
    public class GetController : Controller
    {
        public IActionResult Index(String name)
        {
            ViewData["name"] = name;
           // return System.Web.HttpUtility.HtmlEncode("Hello " + name + " tu metoda GetControllera");
            return View();
        }
    }
}