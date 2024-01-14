using AutoMapper;
using DHotel_Back.DTOs;
using DHotel_Back.Models;

namespace DHotel_Back.Utilidades.Profiles
{
    public class ServiciosOfrecidosProfiles : Profile
    {
        public ServiciosOfrecidosProfiles()
        {
            CreateMap<ServicioOfrecidoCreacionDTO, ServicioOfrecido>();

            CreateMap<ServicioOfrecidoModificacionDTO, ServicioOfrecido>();
        }
    }
}
