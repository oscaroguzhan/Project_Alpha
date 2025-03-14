using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("projects")]
    public class ProjectsController : Controller
    {
        [Route("")]
        // GET: Projects
        public ActionResult Projects()
        {
            return View();
        }

    }
}
