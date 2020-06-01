using JWTToken.Model;
using JWTToken.Services;
using Microsoft.AspNetCore.Mvc;

namespace JWTToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IAuthenticateService _authService;
        public AuthenticationController(IAuthenticateService authService)
        {
            _authService = authService;
        }
        public IActionResult Post(User user)
        {
            var result = _authService.Authenticate(user.Username, user.Password);
            if (result == null)
                return BadRequest(new { message = "username/password is not correct" });
            else
            {
                return Ok(result);
            }
        }
    }
}