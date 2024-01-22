using AutoMapper;
using DHotel_Back.DTOs.UserLoginDTO;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Interfaces.IServices;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DHotel_Back.Interfaces.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAdministradorRepository _administradorRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public AuthService(IAdministradorRepository administradorRepository, IConfiguration configuration, IMapper mapper)
        {
            _administradorRepository = administradorRepository;
            _configuration = configuration;
            _mapper = mapper;
        }
        public async Task<UserResponseDTO> AuthenticateAsync(UserAuthDTO userAuthDto)
        {
            var adminModelo = await _administradorRepository.GetAdministradorByCedula(userAuthDto.Cedula);
            var administrador = _mapper.Map<UserResponseDTO>(adminModelo);
            if (adminModelo != null && VerifyPassword(userAuthDto.Pwd, adminModelo.Pwd))
            {
                return GenerateJwtToken(administrador);
            }
            return null;
        }
        private UserResponseDTO GenerateJwtToken(UserResponseDTO entidad)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
            new Claim("id", entidad.Id.ToString()),
            new Claim("cedula", entidad.Cedula),
            new Claim("nombres", entidad.Nombres),
            new Claim("apellidos", entidad.Apellidos),
            new Claim("rolid", entidad.RolId.ToString()),
            // otras claims que necesites
        }),
                Issuer = _configuration["Jwt:Issuer"],    // Añadir el emisor
                Audience = _configuration["Jwt:Audience"], // Añadir la audiencia
                Expires = DateTime.UtcNow.AddMinutes(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            entidad.Token = tokenHandler.WriteToken(token);
            return entidad;
        }


        private bool VerifyPassword(string PwdLogin, string PwdBase)
        {
            return BCrypt.Net.BCrypt.Verify(PwdLogin, PwdBase);
        }
    }
}
