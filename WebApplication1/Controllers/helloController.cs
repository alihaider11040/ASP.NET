using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class helloController : Controller
    {
        // GET: hello
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name , int intNums)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = intNums;

            return View();
        }
    }
}