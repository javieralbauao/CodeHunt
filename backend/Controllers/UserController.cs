using Microsoft.AspNetCore.Mvc;
using CodeHunt.API.Models;

namespace CodeHunt.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API funcionando correctamente");
        }
    }
}
