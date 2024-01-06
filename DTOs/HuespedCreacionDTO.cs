using DHotel_Back.Models;
using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs
{
    public class HuespedCreacionDTO
    {
        public string Cedula { get; set; } = null!;
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int? GeneroId { get; set; }
        public int? AdministradorId { get; set; }
        [JsonIgnore]
        public DateTime? FechaRegistro { get; set; } = DateTime.Now;
    }
}
