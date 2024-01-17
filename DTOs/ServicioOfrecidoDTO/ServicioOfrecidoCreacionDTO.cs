using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs.ServicioOfrecidoDTO
{
    public class ServicioOfrecidoCreacionDTO
    {
        public ServicioOfrecidoCreacionDTO()
        {
            FechaRegistro = DateTime.Now;
            EstadoId = 1;
        }
        public string? Codigo { get; set; } = null!;
        public string? Nombre { get; set; } = null!;
        public int? AdministradorId { get; set; }
        [JsonIgnore]
        public DateTime? FechaRegistro { get; set; }
        [JsonIgnore]
        public int? EstadoId { get; set; }
    }
}
