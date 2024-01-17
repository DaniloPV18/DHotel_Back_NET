using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs.AdministradorDTO
{
    public class AdministradorModificacionDTO
    {
        public AdministradorModificacionDTO()
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
        public DateTime? FechaNacimiento { get; set; }
        public int? RolId { get; set; }
        public int? AdministradorId { get; set; }
        [JsonIgnore]
        public DateTime? FechaModificacion { get; set; }
        public int? EstadoId { get; set; }
    }
}
