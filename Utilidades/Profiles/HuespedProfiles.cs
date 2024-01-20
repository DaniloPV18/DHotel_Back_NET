using AutoMapper;
using DHotel_Back.DTOs.HuespedDTO;
using DHotel_Back.Models;

namespace DHotel_Back.Utilidades
{
    public class HuespedProfiles : Profile
    {
        public HuespedProfiles()
        {
            CreateMap<Huesped, HuespedDTO>().ReverseMap();

            CreateMap<Huesped, HuespedConsultaDTO>();

            CreateMap<HuespedCreacionDTO, Huesped>();

            CreateMap<HuespedModificacionDTO, Huesped>();            
        }
    }
}
