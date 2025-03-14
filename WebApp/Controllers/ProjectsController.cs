using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProjectsController : Controller
    {
        [Route("/projects")]
        // GET: Projects
        public ActionResult Projects()
        {
            return View();
        }

    }
}
