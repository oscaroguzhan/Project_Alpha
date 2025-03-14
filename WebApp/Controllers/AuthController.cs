using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AuthController : Controller
    {
        // GET: AuthController
       
        public ActionResult Login()
        {
            return View();
        }

    }
}
