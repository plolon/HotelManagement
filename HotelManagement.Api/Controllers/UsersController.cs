using HotelManagement.Application.Models;
using HotelManagement.Identity.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController: ControllerBase
    {
        private readonly IAuthService _authService;

        public UsersController(IAuthService authService)
        {
            _authService = authService;
        }

        // POST: api/<UsersController>/login
        [HttpPost("login")]
        public async Task<IActionResult> Login(AuthRequest request) => Ok(await _authService.Login(request));

       [HttpPost("register")]
       public async Task<IActionResult> Register(RegistrationRequest request) => Ok(await _authService.Register(request)); 
    }
}

