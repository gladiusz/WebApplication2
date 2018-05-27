using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        public UserRepository Userzy = new UserRepository();

        [HttpGet]
        public ActionResult Login()
        {
            UserModel user = new UserModel();
            return View(user);
        }
        [HttpPost]
        public ActionResult Login(UserModel user)
        {
            user = new UserModel();
            if (!ModelState.IsValid)
            {
                Response.Write("<script>alert('"+Resources.Resources.Failed+"');</script>");
                return View(user);
            }

            var usr = Userzy.Get(user.Login, user.Password);
            if(usr == null)
                return View(user);

            Session["UserId"] = usr.Id;
            return RedirectToAction("Index", "Ksiazka");
        }

        [HttpGet]
        public ActionResult Register()
        {
            UserModel user = new UserModel();
            return View(user);
        }
         
        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            user = new UserModel();
            if (!ModelState.IsValid)
            {
                Response.Write("<script>alert('Nie pykło');</script>");
                return View(user);
            }

            var usr = Userzy.Get(user.Login, user.Password);
            if (usr == null)
                Userzy.Add(user);
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            Session["UserId"] = null;
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login");
        }

        public ActionResult SwitchPL()
        {
            Response.Cookies.Add(new System.Web.HttpCookie("Culture", "pl-PL"));
            return RedirectToAction("Login");
        }
        public ActionResult SwitchENG()
        {
            Response.Cookies.Add(new System.Web.HttpCookie("Culture", "en-US"));
            return RedirectToAction("Login");
        }

    }
}