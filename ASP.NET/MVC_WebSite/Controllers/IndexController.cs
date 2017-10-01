using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebSite.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        [Route("WelcomePage")]
        public ActionResult Index()
        {
            return View();
        }
    }
}