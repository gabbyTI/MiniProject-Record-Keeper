using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCHello.Models;

namespace MVCHello.Controllers
{
    public class HomeController : Controller
    {
        OurDBContext db = new OurDBContext();
        public ActionResult Index()
        {
            ViewBag.NumberOfMembers = db.memberAccount.Count();
            return View();
        }

    }
}