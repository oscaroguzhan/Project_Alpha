using Microsoft.AspNetCore.Mvc;
using Business.Models;
namespace WebApp.Controllers
{

    [Route("admin")]
    public class AdminController : Controller
    {
        [Route("members")]
        public IActionResult Members()
        {
            return View();
        }
        [Route("clients")]
        // GET: AdminController
        public IActionResult Clients()
        {
            return View();
        }   
    }
}
