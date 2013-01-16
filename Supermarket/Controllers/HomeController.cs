using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Supermarket.DAL;
using Supermarket.Models;

namespace Supermarket.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Supermarket!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
      

        
    }
}
