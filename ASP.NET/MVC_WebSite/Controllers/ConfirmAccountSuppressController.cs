using System.Web.Mvc;

namespace MVC_WebSite.Controllers
{
    public class ConfirmAccountSuppressController : Controller
    {
        // GET: ConfirmAccountSuppress
        [Route("ConfirmAccountSuppress")]
        public ActionResult IsSuppress()
        {
            return View();
        }
    }
}