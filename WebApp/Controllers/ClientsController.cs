using System.Threading.Tasks;
using Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ClientsController : Controller
    {
       // private readonly IClientService _clientService;
         [HttpPost]
        public async Task<IActionResult> AddClient(AddClientForm form)
        {
            if (!ModelState.IsValid)
            {
                // handle error
                var errors = ModelState
                    .Where(e => e.Value?.Errors.Count > 0)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value?.Errors.Select(e => e.ErrorMessage).ToArray()
                );
                return BadRequest(new { success = false, errors });    
            }
            // send data to clientService
            // var result = await _clientService.AddClientAsync(form);
            // if (result)
            // {
            //     return Ok(new { success = true });
            // }else 
            // {
            //     return Problem("Error adding client");
            // }
            return Ok(new { success = true });
            
            
        }

        [HttpPost]
        public IActionResult EditClient(EditClientForm form)
        {
            if (!ModelState.IsValid)
            {
                // handle error
                var errors = ModelState
                    .Where(e => e.Value?.Errors.Count > 0)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value?.Errors.Select(e => e.ErrorMessage).ToArray()
                );
                return BadRequest(new { success = false, errors });    
            }

            // send data to clientService
            // send data to clientService
            // var result = await _clientService.UpdateClientAsync(form);
            // if (result)
            // {
            //     return Ok(new { success = true });
            // }else 
            // {
            //     return Problem("Error update the client");
            // }
            
            return Ok(new { success = true });
        }
    }
}
