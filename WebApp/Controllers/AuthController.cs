using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AuthController : Controller
    {
        // GET: AuthController
       
        public ActionResult Login()
        {
            //FIXME - REDIRECT TO THE PROJECTS PAGE
            //return View();
            return LocalRedirect("/projects");
        }

    }
}
