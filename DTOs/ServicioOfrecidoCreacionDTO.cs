using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs
{
    public class ServicioOfrecidoCreacionDTO
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int? AdministradorId { get; set; }
        [JsonIgnore]
        public DateTime? FechaRegistro { get; set; } = DateTime.Now;
        [JsonIgnore]
        public int? EstadoId { get; set; } = 1;
    }
}
