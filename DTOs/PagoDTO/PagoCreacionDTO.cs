using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs.PagoDTO
{
    public class PagoCreacionDTO
    {
        public PagoCreacionDTO()
        {
            FechaRegistro = DateTime.Now;
            EstadoId = 1;
        }
        public int? HabitacionId { get; set; }
        public int? AdministradorId { get; set; }
        public int? HuespedId { get; set; }
        public int? TipoPagoId { get; set; }
        public decimal? ValorPagado { get; set; }
        public decimal? ValorAPagar { get; set; }
        public string? ServiciosHabitacion { get; set; } = null!;
        [JsonIgnore]
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        [JsonIgnore]
        public int? EstadoId { get; set; }
    }
}
