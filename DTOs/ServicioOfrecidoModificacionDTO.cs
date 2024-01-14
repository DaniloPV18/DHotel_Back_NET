using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs
{
    public class ServicioOfrecidoModificacionDTO
    {
        public ServicioOfrecidoModificacionDTO()
        {
            FechaModificacion = DateTime.Now;
        }
        public int Id { get; set; }
        public string? Codigo { get; set; } = null!;
        public string? Nombre { get; set; } = null!;
        public int? AdministradorId { get; set; }
        [JsonIgnore]
        public DateTime? FechaModificacion { get; set; }
        public int? EstadoId { get; set; }
    }
}
