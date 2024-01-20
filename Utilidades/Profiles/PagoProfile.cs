using AutoMapper;
using DHotel_Back.DTOs.PagoDTO;
using DHotel_Back.Models;

namespace DHotel_Back.Utilidades.Profiles
{
    public class PagoProfile : Profile
    {
        public PagoProfile()
        {
            CreateMap<Pago, PagoConsultaDTO>().ReverseMap();

            CreateMap<PagoCreacionDTO, Pago>();

            CreateMap<PagoModificacionDTO, Pago>();
        }
    }
}
