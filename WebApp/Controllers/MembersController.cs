using Microsoft.AspNetCore.Mvc;
using Business.Models;
namespace WebApp.Controllers
{
    public class MembersController : Controller
    {
        [HttpPost]
        public IActionResult AddMember(AddMemberForm form) {
            if (!ModelState.IsValid)
            {
                // handle error
                var errors = ModelState
                    .Where(e => e.Value?.Errors.Count > 0)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value?.Errors.Select(e => e.ErrorMessage).ToArray()
                );
                return BadRequest(new { success = false, errors });
            }

            // send data to memberService
            // var result = await _memberService.AddMemberAsync(form);
            // if (result)
            // {
            //     return Ok(new { success = true });
            // }else 
            // {
            //     return Problem("Error adding member");
            // }
            return Ok(new { success = true });
        }
        [HttpPost]
        public IActionResult EditMember(EditMemberForm form) {
            if (!ModelState.IsValid)
            {
                // handle error
                var errors = ModelState
                    .Where(e => e.Value?.Errors.Count > 0)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value?.Errors.Select(e => e.ErrorMessage).ToArray()
                );
                return BadRequest(new { success = false, errors });
            }

            // send data to memberService
            // var result = await _memberService.AddMemberAsync(form);
            // if (result)
            // {
            //     return Ok(new { success = true });
            // }else 
            // {
            //     return Problem("Error adding member");
            // }
            return Ok(new { success = true });
        }
    }  
}

