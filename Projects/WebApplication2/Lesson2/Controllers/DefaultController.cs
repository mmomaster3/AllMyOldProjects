using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Sum = x + y;
            }
            return View();
        }
    }
}