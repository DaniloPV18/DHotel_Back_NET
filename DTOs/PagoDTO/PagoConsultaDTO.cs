using DHotel_Back.DTOs.AbonoReservaDTO;

namespace DHotel_Back.DTOs.PagoDTO
{
    public class PagoConsultaDTO
    {
        public int Id { get; set; }
        public HabitacionDTO.HabitacionDTO? Habitacion { get; set; } = null!;
        public AdministradorDTO.AdministradorDTO? Administrador { get; set; } = null!;
        public HuespedDTO.HuespedDTO? Huesped { get; set; } = null!;
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
