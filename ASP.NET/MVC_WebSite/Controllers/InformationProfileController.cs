using MVC_WebSite.Models;
using MVC_WebSite.Models.EDM;
using System.Web.Mvc;

namespace MVC_WebSite.Controllers
{
    public class InformationProfileController : Controller
    {
        static BDD access = new BDD();

        // GET: InformationProfile
        [Route("InformationProfile")]
        public ActionResult InfoProfile([Bind(Include = "Login, Password, Email")]AuthData u)
        {
            User user = ProfileEvent.DisplayUser((string)Session["userSession"]);
            if (Session["userSession"] == null) { RedirectToAction("BuildConnexionForm", "Authentication"); }
          //z  access.SaveChanges();
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult InfoProfile(User u)
        {
            if (ControllerContext.HttpContext.Request.Form["suppProfile"] != null)
            {
                BDD ac = new BDD();
                u = ProfileEvent.SuppressAcount((string)Session["userSession"]);
                ac.User.Remove(u);
                ac.SaveChanges();
                return RedirectToAction("IsSuppress", "ConfirmAccountSuppress");
            }
            Session["userSession"] = null;
            return RedirectToAction("BuildConnexionForm", "Authentication");
        }
    }
}