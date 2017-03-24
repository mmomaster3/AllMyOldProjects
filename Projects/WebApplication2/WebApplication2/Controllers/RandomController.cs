using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class RandomController : Controller
    {
        // GET: Random
        public ActionResult Index()
        {
            List<WebApplication2.Models.Random> list = new List<WebApplication2.Models.Random>();
            list.Add(new WebApplication2.Models.Random()
            {
                number = 1, numberOnString = "one"

            });
            list.Add(new Models.Random()
            {
                number = 2, numberOnString = "two"
            });
            list.Add(new Models.Random()
            {
                number = 3,
                numberOnString = "tree"
            });

            return View(list);
        }
    }
}