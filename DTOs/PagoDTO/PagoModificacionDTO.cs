using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs.PagoDTO
{
    public class PagoModificacionDTO
    {
        public PagoModificacionDTO()
        {
            FechaModificacion = DateTime.Now;
        }
        public int Id { get; set; }
        public int? HabitacionId { get; set; }
        public int? AdministradorId { get; set; }
        public int? HuespedId { get; set; }
        public int? TipoPagoId { get; set; }
        public decimal? ValorPagado { get; set; }
        public decimal? ValorAPagar { get; set; }
        public string? ServiciosHabitacion { get; set; } = null!;
        [JsonIgnore]
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? EstadoId { get; set; }
    }
}
