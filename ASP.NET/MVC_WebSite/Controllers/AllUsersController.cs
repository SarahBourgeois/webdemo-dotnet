using MVC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebSite.Controllers
{
    public class AllUsersController : Controller
    {
        // GET: AllUsers
        [Route("AllUsers")]  //get
        public ActionResult AllUsersProfile([Bind(Include = "UsersList")]AuthData u)
        {
            if (Session["userSession"] == null) { return RedirectToAction("BuildConnexionForm", "Authentication"); }
            u.UsersList = ProfileEvent.DisplayAllUsers();
            return View(u);
        }
    }
}