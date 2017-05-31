using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FBCodingChallenge.Models;
using FBCodingChallenge.MTIntegration;

namespace FBCodingChallenge.Controllers
{
    public class UserInfoController : Controller
    {
        UxMTIntegration _uxMtIntegration = new UxMTIntegration();

        //The Dependency Injection of the IRepository<TEnt, in TPk>
        public UserInfoController()
        {
        }

        public ActionResult SignupView()
        {
            UserModel userinfo = new UserModel();
            userinfo.UserName = "Aarti Verma";
            userinfo.EmailAddress = "aartichoudhary21@gmail.com";
            userinfo.Password = "123";
            AddUser(userinfo);
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(UserModel userinfo)
        {
            _uxMtIntegration.AddUser(userinfo);
            return new EmptyResult();
        }

        //GET: UserInfo
        public ActionResult Index()
        {
          return View();
        }

    }
}