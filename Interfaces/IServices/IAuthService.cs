using DHotel_Back.DTOs.UserLoginDTO;

namespace DHotel_Back.Interfaces.IServices
{
    public interface IAuthService
    {
        Task<UserResponseDTO> AuthenticateAsync(UserAuthDTO userAuthDto);
    }
}
