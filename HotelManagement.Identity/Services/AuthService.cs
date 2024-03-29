using HotelManagement.Application.Models;
using HotelManagement.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HotelManagement.Domain.Repositories;
using AutoMapper;

namespace HotelManagement.Identity.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JwtSettings _jwtSettings;
        private readonly IMapper _mapper;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUnitOfWork _unitOfWork;

        public AuthService(UserManager<ApplicationUser> userManager,
            IOptions<JwtSettings> jwtSettings,
            SignInManager<ApplicationUser> signInManager,
            IMapper mapper,
            IUnitOfWork _unitOfWork
            )
        {
            _jwtSettings = jwtSettings.Value;
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            this._unitOfWork = _unitOfWork;
        }

        public async Task<AuthResponse> Login(AuthRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                throw new Exception($"User with {request.Email} not found.");
            var result = await _signInManager.PasswordSignInAsync(user.UserName,
                request.Password, false, lockoutOnFailure: false);

            if (!result.Succeeded)
                throw new Exception(
                    $"Credentials for {request.Email} aren't valid.");

            JwtSecurityToken jwtToken = await GenerateToken(user);

            AuthResponse response = new AuthResponse
            {
                Id = user.Id,
                Token = new JwtSecurityTokenHandler().WriteToken(jwtToken),
                Email = user.Email,
                UserName = user.UserName
            };
            return response;
        }

        public async Task<ApplicationUser> Register(RegistrationRequest request)
        {
            var isUserExists = await _userManager.FindByEmailAsync(request.Email);

            if (isUserExists != null)
                throw new Exception("User with this email already exists");

            var newUser = _mapper.Map<ApplicationUser>(request);

            var hasher = new PasswordHasher<ApplicationUser>();

            newUser.PasswordHash = hasher.HashPassword(null, request.Password);
            var res = await _userManager.CreateAsync(newUser);
            await _userManager.AddToRoleAsync(newUser, "Guest");
            await _unitOfWork.Complete();

            return newUser;
        }

        public async Task<bool> DeleteUser(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                return false;
            try
            {
                await _userManager.DeleteAsync(user);
                return true;
            }
            catch
            {
                // TODO inject logger for stack trace with error message :) 
                return false;
            }
            await _userManager.DeleteAsync(user);
        }
        
        private async Task<JwtSecurityToken> GenerateToken(ApplicationUser user)
        {
            IList<Claim> userClaims = await _userManager.GetClaimsAsync(user);
            IList<string> roles = await _userManager.GetRolesAsync(user);
            List<Claim> roleClaims = new List<Claim>();
            roles.ToList()
                .ForEach((role) => roleClaims
                    .Add(new Claim("roles", role)));
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti,
                    Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
            }.Union(userClaims).Union(roleClaims);

            var symmetricSecurityKey =
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_jwtSettings.Key));

            var signingCredentials =
                new SigningCredentials(symmetricSecurityKey,
                    SecurityAlgorithms.HmacSha256);

            var jwtToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: signingCredentials
            );
            return jwtToken;
        }
    }
}
