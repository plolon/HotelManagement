using HotelManagement.Application.Models;
using HotelManagement.Identity.Services;
using Microsoft.AspNetCore.Mvc;
using ILogger = Serilog.ILogger;

namespace HotelManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ILogger _logger;

        public UsersController(IAuthService authService, ILogger logger)
        {
            _authService = authService;
            _logger = logger;
        }

        // POST: api/<UsersController>/login
        [HttpPost("login")]
        public async Task<IActionResult> Login(AuthRequest request)
        {
            _logger.Information("UsersController POST login start");
            return Ok(await _authService.Login(request));
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegistrationRequest request)
        {
            _logger.Information("UsersController POST Register start");
            return Ok(await _authService.Register(request));
        }
    }
}