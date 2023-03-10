using AuthMiddlewareExample.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthMiddlewareExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        // GET: api/<ToDoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }  
        
        [HttpPost]
        public IActionResult Test(ToDoDto todo)
        {

            
           return Ok(todo);
        }


    }
}
