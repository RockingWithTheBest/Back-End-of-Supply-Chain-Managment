using Back_End.Models;
using Back_End.Repositories.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;


namespace Back_End.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class TryingController : Controller
    {
        private ITrying _tryrepo;

        public TryingController(ITrying tryrepo)
        {
            _tryrepo = tryrepo;
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("Index")]
        public IActionResult Index()
        {
            var a = _tryrepo.GetAllTryings();
            if (a == null) 
            {
                return NotFound();
            }
            return Ok(a);
        }

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("GetById")]
        public IActionResult GetById(int id)
        {
            Customer a = _tryrepo.GetById(id);
            if (a == null)
            {
                return NotFound();
            }
            return Ok(a);
        }

        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("Creates")]
        public IActionResult Creates(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return the model state errors
            }
            int a = _tryrepo.CreateTry(customer);
            if (a <= 0)
            {
                return BadRequest("Failed");
            }
            else
                return Ok("Added! "+a);
        }

        [HttpPut]
        [Microsoft.AspNetCore.Mvc.Route("Edit")]
        public IActionResult Edit(Customer customer)
        {
            int a = _tryrepo.UpdateTry(customer);
            if (a <= 0)
            {
                return BadRequest("Failed");
            }
            else
               return Ok("Updated! " + a);
        }

        [HttpDelete]
        [Microsoft.AspNetCore.Mvc.Route("Delete")]
        public IActionResult Delete(int id)
        {
            int a = _tryrepo.DeleteTry(id);
            if (a <= 0)
            {
                return BadRequest("Failed");
            }
            else
                return Ok("Deleted! " + a);
        }
    }
}
