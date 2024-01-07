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

            CreateMap<HuespedCreacionDTO, Huesped>();

            CreateMap<HabitacionCreacionDTO, Habitacion>()
                .ForMember( ent => ent.HabitacionServicioOfrecido, 
                            opt => opt.Ignore());

            CreateMap<HabitacionServicioOfrecidoCreacionDTO, HabitacionServicioOfrecido>();

            CreateMap<ServicioOfrecidoCreacionDTO, ServicioOfrecido>();
        }
    }
}
