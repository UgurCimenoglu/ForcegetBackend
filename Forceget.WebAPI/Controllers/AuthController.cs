using Forceget.Business.Abstract;
using Forceget.Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forceget.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(UserForRegisterDto registerDto)
        {
            var result = await _authService.RegisterAsync(registerDto, registerDto.Password);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login(UserForLoginDto loginDto)
        {
            var result = await _authService.LoginAsync(loginDto);
            if (result.Success)
            {
                var token = _authService.CreateAccessToken(result.Data);
                return Ok(token);
            }

            return BadRequest(result);
        }
    }
}
