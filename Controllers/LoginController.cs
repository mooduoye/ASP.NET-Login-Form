using ASP.NET_Login_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Login_Form.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("LoginForm");
        }

        public ActionResult Login(UserModel userModel)
        {
            if (userModel.Username =="admin" && userModel.Password == "superuser")
            {
                return View("LoginSuccess", userModel);
            }
            else
            {
                ViewBag.Message = "Login Failled!.";
                return View("LoginForm");
            }
            
        }
    }
}