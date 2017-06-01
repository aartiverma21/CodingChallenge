using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using FBCodingChallenge.MTIntegration;
using FBCodingChallenge.Models;

namespace FBCodingChallenge.Controllers
{
    public class AuthenticationController : Controller
    {
        UxMTIntegration _uxMtIntegration = new UxMTIntegration();

        // GET: Authentication
        public bool SignInText(HtmlHelper helper)
        {
            return helper.ViewContext.HttpContext.Request.IsAuthenticated;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddUser(UserModel userinfo)
        {
            _uxMtIntegration.AddUser(userinfo);
            SaveUserSessionInfo(userinfo);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignInUser(UserModel userinfo)
        {
            _uxMtIntegration.GetUser(userinfo);
            SaveUserSessionInfo(userinfo);
            return RedirectToAction("Index", "Home");
        }

        public void SaveUserSessionInfo(UserModel userinfo)
        {
            if (ModelState.IsValid)
            {
                var profileData = new UserModel()
                {
                    UserName  = userinfo.UserName,
                    EmailAddress = userinfo.EmailAddress,
                    Password = userinfo.Password
                };
                this.Session["UserModel"] = profileData;
            }

        }

        public ActionResult SignOut()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}