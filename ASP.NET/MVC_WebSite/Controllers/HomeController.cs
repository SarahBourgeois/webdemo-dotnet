using MVC_WebSite.Models;
using System.Web.Mvc;

namespace MVC_WebSite.Controllers
{

    public class HomeController : Controller
    {
        [Route("Home")]
        public ActionResult Index([Bind(Include = "Name, Description, ItemList")]ItemData u)
        {
            u.ItemList = ItemEvent.InitItemList((string)Session["userSession"]);
            if (Session["userSession"] == null) { return RedirectToAction("BuildConnexionForm", "Authentication"); }
            return View(u);
        }
    }
}