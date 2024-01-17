using AutoMapper;
using DHotel_Back.DTOs.AdministradorDTO;
using DHotel_Back.Models;

namespace DHotel_Back.Utilidades
{
    public class AdministradorProfiles : Profile
    {
        public AdministradorProfiles()
        {
            CreateMap<Administrador, AdministradorConsultaDTO>();
            
            CreateMap<AdministradorCreacionDTO, Administrador>();

            CreateMap<AdministradorModificacionDTO, Administrador>();
        }
    }
}
