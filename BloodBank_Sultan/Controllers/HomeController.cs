using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sultan_FinalBB.Models;

namespace Sultan_FinalBB.Controllers
{
    public class HomeController : Controller
    {
        Sultan_FinalBBEntities db = new Sultan_FinalBBEntities();

        public ActionResult Index()
        {
            var req = db.Requests.OrderByDescending(r => r.ReqID).ToList().Take(3);

            ViewBag.requests = req;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}