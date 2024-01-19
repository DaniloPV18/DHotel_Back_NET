using AutoMapper;
using DHotel_Back.DTOs.AbonoReservaDTO;
using DHotel_Back.Models;

namespace DHotel_Back.Utilidades.Profiles
{
    public class AbonoReservaProfile : Profile
    {
        public AbonoReservaProfile()
        {
            CreateMap<AbonoReserva, AbonoReservaConsultaDTO>();
        }
    }
}
