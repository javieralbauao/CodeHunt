using Microsoft.AspNetCore.Mvc;
using CodeHunt.API.Models;

namespace CodeHunt.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto credentials)
        {
            // Validación básica quemada (solo para probar conexión)
            if (credentials.Username == "admin" && credentials.Password == "1234")
            {
                return Ok(new { token = "simulated-jwt-token-123456" });
            }

            return Unauthorized("Credenciales inválidas");
        }
    }
}
