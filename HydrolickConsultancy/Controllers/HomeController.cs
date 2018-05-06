using HydrolickConsultancy.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HydrolickConsultancy.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [WhiteSpaceFilter]
        public ActionResult Index()
        {
            return View();
        }
        [WhiteSpaceFilter]

        public ActionResult AboutUs()
        {
            return View();
        }
        [WhiteSpaceFilter]

        public ActionResult ContactUs()
        {
            return View();
        }
        [WhiteSpaceFilter]

        public ActionResult News()
        {
            return View();
        }
        [WhiteSpaceFilter]

        public ActionResult Investor()
        {
            return View();
        }
        [WhiteSpaceFilter]

        public ActionResult Enterpreneur()
        {
            return View();
        }
    }
}