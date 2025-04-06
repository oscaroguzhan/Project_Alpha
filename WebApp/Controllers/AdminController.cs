using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        [Route("members")]
        // GET: AdminController
        public ActionResult Members()
        {
            return View();
        }
        [Route("clients")]
        // GET: AdminController
        public ActionResult Clients()
        {
            return View();
        }

    }
}
