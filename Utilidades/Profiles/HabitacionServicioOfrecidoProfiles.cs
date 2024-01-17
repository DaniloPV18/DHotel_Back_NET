using AutoMapper;
using DHotel_Back.DTOs.AdministradorDTO;
using DHotel_Back.DTOs.HabitacionServicioOfrecidoCreacionDTO;
using DHotel_Back.Models;

namespace DHotel_Back.Utilidades
{
    public class HabitacionServicioOfrecidoProfiles : Profile
    {
        public HabitacionServicioOfrecidoProfiles()
        {
            CreateMap<HabitacionServicioOfrecido, HabitacionServicioOfrecidoConsultaDTO>();
        }
    }
}
