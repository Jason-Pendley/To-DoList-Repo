using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Dictionary<int, string> TaskList = new Dictionary<int, string>();
            TaskList.Add(1, "Clean my room");
            TaskList.Add(2, "Read a book");
            TaskList.Add(3, "Go to the grocery store");
            TaskList.Add(4, "Fix yourself some dinner");
            ViewBag.DataSource = TaskList;
            return View();
        }
    }
}
