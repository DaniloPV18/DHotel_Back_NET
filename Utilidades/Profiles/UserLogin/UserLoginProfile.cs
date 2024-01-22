using AutoMapper;
using DHotel_Back.DTOs.UserLoginDTO;
using DHotel_Back.Models;

namespace DHotel_Back.Utilidades.Profiles.UserLogin
{
    public class UserLoginProfile : Profile
    {
        public UserLoginProfile()
        {
            CreateMap<Administrador, UserResponseDTO>()
                .ForMember(dest => dest.Token, opt => opt.Ignore());
        }
    }
}
