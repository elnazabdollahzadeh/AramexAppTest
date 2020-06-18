using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/// <summary>
/// YOU SHOULD NOT NEED TO EDIT THIS FILE
/// </summary>
namespace AramexApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Aramex App Test";

            return View();
        }
    }
}