using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CodeHunt.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // ✅ Este endpoint permite acceso sin autenticación
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Get()
        {
            return Ok("API funcionando correctamente");
        }
    }
}
