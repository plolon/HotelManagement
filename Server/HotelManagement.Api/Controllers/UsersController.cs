using HotelManagement.Application.Models;
using HotelManagement.Identity.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Api.Controllers
{
    public class UsersController: ControllerBase
    {
        private readonly IAuthService _authService;

        public UsersController(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<IActionResult> Login(AuthRequest request) => Ok(await _authService.Login(request));
        
    }
}