using AutoMapper;
using DHotel_Back.DTOs.HabitacionServicioOfrecidoCreacionDTO;
using DHotel_Back.DTOs.ServicioOfrecidoDTO;
using DHotel_Back.Models;

namespace DHotel_Back.Utilidades.Profiles
{
    public class ServiciosOfrecidosProfiles : Profile
    {
        public ServiciosOfrecidosProfiles()
        {
            CreateMap<ServicioOfrecido, ServicioOfrecidoConsultaDTO>();

            CreateMap<ServicioOfrecidoCreacionDTO, ServicioOfrecido>();

            CreateMap<ServicioOfrecidoModificacionDTO, ServicioOfrecido>();
        }
    }
}
