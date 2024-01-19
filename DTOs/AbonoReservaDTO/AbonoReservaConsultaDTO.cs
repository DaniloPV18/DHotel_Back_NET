using DHotel_Back.DTOs.AdministradorDTO;
using DHotel_Back.DTOs.PagoDTO;

namespace DHotel_Back.DTOs.AbonoReservaDTO
{
    public class AbonoReservaConsultaDTO
    {
        public int Id { get; set; }
        public int? PagoId { get; set; }
        public PagoConsultaDTO? Pago { get; set; } = null!;
        public AdministradorConsultaDTO? Administrador { get; set; }
        public decimal? ValorPagado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? EstadoId { get; set; }
    }
}
