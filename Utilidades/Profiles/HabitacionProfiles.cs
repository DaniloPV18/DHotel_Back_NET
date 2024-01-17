using AutoMapper;
using DHotel_Back.DTOs.HabitacionDTO;
using DHotel_Back.DTOs.HabitacionServicioOfrecidoCreacionDTO;
using DHotel_Back.Models;

namespace DHotel_Back.Utilidades
{
    public class HabitacionProfiles : Profile
    {
        public HabitacionProfiles()
        {
            CreateMap<Habitacion, HabitacionConsultaDTO>();

            CreateMap<HabitacionCreacionDTO, Habitacion>()
                .ForMember(ent => ent.HabitacionServicioOfrecido, opt => opt.Ignore())
                .ForMember(ent => ent.Foto, opt => opt.Ignore());

            CreateMap<HabitacionServicioOfrecidoCreacionDTO, HabitacionServicioOfrecido>();
        }
    }
}
