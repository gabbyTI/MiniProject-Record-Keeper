using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCHello.Models;

namespace MVCHello.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Members member)
        {
            if (ModelState.IsValid)
            {
                using(OurDBContext db = new OurDBContext())
                {
                    db.memberAccount.Add(member);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = member.FirstName + " " + member.LastName + "'s Account has been created successfully";
                return RedirectToAction("Login");
            }

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Members member)
        {
            using(OurDBContext db = new OurDBContext())
            {
                var user = db.memberAccount.Single(u => u.Username == member.Username && u.Password == member.Password);

                if (user != null)
                {
                    Session["UserID"] = user.MemberID.ToString();
                    Session["Username"] = user.Username.ToString();
                    return RedirectToAction("index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password is incorrect");
                }
            }
            return View();
        }
    }
}