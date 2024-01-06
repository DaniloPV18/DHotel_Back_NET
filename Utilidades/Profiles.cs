using AutoMapper;
using DHotel_Back.DTOs;
using DHotel_Back.Models;

namespace DHotel_Back.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AdministradorCreacionDTO, Administrador>();

            CreateMap<ServicioOfrecidoCreacionDTO, ServicioOfrecido>();
        }
    }
}
