using AutoMapper;
using DHotel_Back.DTOs.HabitacionDTO;
using DHotel_Back.Models;

namespace DHotel_Back.Utilidades
{
    public class HabitacionProfiles : Profile
    {
        public HabitacionProfiles()
        {
            CreateMap<Habitacion, HabitacionDTO>();

            CreateMap<Habitacion, HabitacionConsultaDTO>();

            CreateMap<HabitacionCreacionDTO, Habitacion>()
                .ForMember(ent => ent.HabitacionServicioOfrecido, opt => opt.Ignore())
                .ForMember(ent => ent.Foto, opt => opt.Ignore());

            CreateMap<HabitacionModificacionDTO, Habitacion>()
                .ForMember(ent => ent.HabitacionServicioOfrecido, opt => opt.Ignore())
                .ForMember(ent => ent.Foto, opt => opt.Ignore());

        }
    }
}
