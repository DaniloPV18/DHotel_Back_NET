using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs.AdministradorDTO
{
    public class AdministradorCreacionDTO
    {
        public AdministradorCreacionDTO()
        {
            FechaRegistro = DateTime.Now;
            EstadoId = 1;
        }
        public string? Cedula { get; set; } = null!;
        public string? Nombres { get; set; } = null!;
        public string? Apellidos { get; set; } = null!;
        public string? Celular { get; set; } = null!;
        public string? Email { get; set; } = null!;
        public int? GeneroId { get; set; }
        public string? Pwd { get; set; } = null!;
        public DateTime? FechaNacimiento { get; set; }
        public int? RolId { get; set; }
        public int? AdministradorId { get; set; }
        [JsonIgnore]
        public DateTime? FechaRegistro { get; set; }
        [JsonIgnore]
        public int? EstadoId { get; set; }
    }
}
