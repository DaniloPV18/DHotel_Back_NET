using DHotel_Back.DTOs.AbonoReservaDTO;
using DHotel_Back.DTOs.HabitacionDTO;
using DHotel_Back.DTOs.HuespedDTO;

namespace DHotel_Back.DTOs.PagoDTO
{
    public class PagoConsultaDTO
    {
        public int Id { get; set; }
        public HabitacionConsultaDTO? Habitacion { get; set; } = null!;
        public HuespedConsultaDTO? Huesped { get; set; } = null!;
        public int? TipoPagoId { get; set; }
        public decimal? ValorPagado { get; set; }
        public decimal? ValorAPagar { get; set; }
        public string? ServiciosHabitacion { get; set; } = null!;
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? EstadoId { get; set; }
        public List<AbonoReservaConsultaDTO>? AbonosReservasDTO { get; set; } = new List<AbonoReservaConsultaDTO>();
    }
}
