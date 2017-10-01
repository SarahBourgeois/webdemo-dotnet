using MVC_WebSite.Models;
using MVC_WebSite.Models.EDM;
using System.Web.Mvc;

namespace MVC_WebSite.Controllers
{
    public class SignUpController : Controller
    {
        BDD access = new BDD();

        [Route("SignUp")]
        public ActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult CreateAccount([Bind(Include = "Login, Password, Email")]AuthData u)
        {
            BDD acc = new BDD();
            User useradd = ProfileEvent.addUser(u.Login, u.Password);
         //   u.Password = CryptPassword.CryptSha256(u.Password);  --> to encrypyt password
            if (useradd == null)
            {
                acc.User.Add(new User()
                {
                    login = u.Login,
                    password = u.Password,
                    email = u.Email
                });
                acc.SaveChanges();
                Session["emailSession"] = u.Email;
                Session["password"] = u.Password;
                return RedirectToAction("BuildConnexionForm", "Authentication");
            }
            ModelState.AddModelError("Login", "The login or the email is already user");
            return View(u);
        }

    }
}