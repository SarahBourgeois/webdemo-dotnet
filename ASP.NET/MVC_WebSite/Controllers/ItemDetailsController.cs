using MVC_WebSite.Models;
using MVC_WebSite.Models.EDM;
using System.Web.Mvc;

namespace MVC_WebSite.Controllers
{
    public class ItemDetailsController : Controller
    {
        BDD access = new BDD();

        [HttpGet]
        public ActionResult ModifyItem()
        {
           ItemData u = new ItemData();
            string session = (string)Session["userSession"];
            string idUrl = Request.QueryString["id"];
            Item item = ItemEvent.displayItem(idUrl, session);
            if (item == null) { return View(); }
            u.Name = item.name;
            u.Description = item.description;
            return View(u);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult ModifyItem([Bind(Include = "Name, Description, NewName, NewDescription")]ItemData u)
        {
            {
                string idUrl = Request.Params["id"];
                if (ControllerContext.HttpContext.Request.Form["modify"] != null)
                {
                    ItemEvent.ModifyItem(idUrl, u.NewName, u.NewDescription);
                    return RedirectToAction("Index", "Home");
                }
                ItemEvent.SuppressItem(idUrl);
                return RedirectToAction("Index", "Home");
            }
        }
    }
}