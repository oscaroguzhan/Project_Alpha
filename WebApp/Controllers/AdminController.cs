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
        [HttpPost]
        
        // POST: AdminController
        public IActionResult AddClient(AddClientForm form)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Clients");
         
            // If the model state is not valid, return the same view with validation errors
            return View();
        }

        [HttpPost]
        public IActionResult EditClient(AddClientForm form)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Clients");
         
            // If the model state is not valid, return the same view with validation errors
            return View();
        }
        
    }
}
