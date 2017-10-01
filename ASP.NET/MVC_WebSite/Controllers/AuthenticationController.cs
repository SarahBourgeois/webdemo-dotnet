using System.Web.Mvc;
using MVC_WebSite.Models;
using MVC_WebSite.Models.EDM;

namespace MVC_WebSite.Controllers
{
    public class AuthenticationController : Controller
    {
    
        // GET: Authentication

        [Route("Authentication")]  //get
        public ActionResult BuildConnexionForm()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult BuildConnexionForm([Bind(Include = "Login, Password")]AuthData u)
        {
           
            User visitor = ProfileEvent.UserConnect(u.Login, u.Password);
            if (visitor == null)
            {
                ModelState.AddModelError("Login", "You have no account available.");
                return View();
            }
            Session["userSession"] = u.Login;
            Session["pswSession"] = u.Password;
            Session["emailSession"] = u.Email;

            return RedirectToAction("Index", "Index");
        }


    }
}
