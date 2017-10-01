using MVC_WebSite.Models;
using MVC_WebSite.Models.EDM;
using System.Web.Mvc;

namespace MVC_WebSite.Controllers
{
    public class AddItemController : Controller
    {
        [Route("AddItem")] 
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult CreateForm([Bind(Include = "Name, Description")]ItemData u)
        {
            string a = (string)Session["userSession"];
            BDD access = new BDD();   
            User user = ItemEvent.AddItem(a);
            if (user.Equals(null)) { return View(u); }
            access.Item.Add(new Item()
            {
                name = u.Name,
                description = u.Description,
                user = user.Id
            });
            access.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}