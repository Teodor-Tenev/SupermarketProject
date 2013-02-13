using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Supermarket.Controllers
{
    public class ErrorsController : Controller
    {
        /// <summary>
        /// General exception
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        //public ActionResult General(Exception exception)
        //{
        //    return Content("General failure", "text/plain");
        //}

        /// <summary>
        /// Action for HTTP404 exception
        /// </summary>
        /// <returns>Page not found</returns>
        public ActionResult Http404()
        {
            return View("PageNotFound");
        }

        /// <summary>
        /// Action for HTTP403 exception
        /// </summary>
        /// <returns>Page not allowed</returns>
        public ActionResult Http403()
        {
            return View("PageNotAllowed");
        }

    }
}
