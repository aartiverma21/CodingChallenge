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

       

        //GET: UserInfo
        public ActionResult Index()
        {
          return View();
        }

    }
}