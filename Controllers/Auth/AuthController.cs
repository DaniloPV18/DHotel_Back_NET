using DHotel_Back.DTOs.UserLoginDTO;
using DHotel_Back.Interfaces.IServices;
using DHotel_Back.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DHotel_Back.Controllers.Auth
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        public AuthController(AuthService authService)
        {
            _authService = authService;
        }
        [HttpPost]
        public async Task<ActionResult<UserResponseDTO>> Login([FromBody] UserAuthDTO userAuthDto)
        {
            var userResponseDTO = await _authService.AuthenticateAsync(userAuthDto);

            if (userResponseDTO != null)
            {
                return Ok(userResponseDTO);
            }

            return Unauthorized();
        }
        [HttpPost("pwd")]
        public async Task<ActionResult<string>> Generate([FromBody] UserAuthDTO userAuthDto)
        {
            return BCrypt.Net.BCrypt.HashPassword(userAuthDto.Cedula);
        }
    }
}
