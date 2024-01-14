using AutoMapper;
using DHotel_Back.DTOs;
using DHotel_Back.Models;

namespace DHotel_Back.Utilidades
{
    public class AdministradorProfiles : Profile
    {
        public AdministradorProfiles()
        {
            CreateMap<AdministradorCreacionDTO, Administrador>();

            CreateMap<AdministradorModificacionDTO, Administrador>();
        }
    }
}
