using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CodeHunt.API.DTOs;
using CodeHunt.API.Services;

namespace CodeHunt.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _auth;

        public AuthController(AuthService auth)
        {
            _auth = auth;
        }

        // POST: api/auth/login
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO dto)
        {
            // Simulación de validación de usuario (luego lo conectas a una base de datos)
            if (dto.Username == "admin" && dto.Password == "1234")
            {
                var token = _auth.GenerateToken(dto.Username);
                return Ok(new { token });
            }

            return Unauthorized("Credenciales inválidas");
        }

        // GET: api/auth/test
        [HttpGet("test")]
        [Authorize]
        public IActionResult TestJWT()
        {
            var username = User.Identity?.Name;
            return Ok($"Hola {username}, estás autenticado con JWT");
        }
    }
}
