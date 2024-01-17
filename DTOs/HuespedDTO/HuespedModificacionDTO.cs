using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs.HuespedDTO
{
    public class HuespedModificacionDTO
    {
        public HuespedModificacionDTO()
        {
            FechaModificacion = DateTime.Now;
        }
        public int Id { get; set; }
        public string? Cedula { get; set; } = null!;
        public string? Nombres { get; set; } = null!;
        public string? Apellidos { get; set; } = null!;
        public string? Celular { get; set; } = null!;
        public string? Email { get; set; } = null!;
        public int? GeneroId { get; set; }
        public int? AdministradorId { get; set; }
        [JsonIgnore]
        public DateTime? FechaModificacion { get; set; }
    }
}
