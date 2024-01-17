using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs.AdministradorDTO
{
    public class AdministradorConsultaDTO
    {
        public int Id { get; set; }
        public string? Cedula { get; set; } = null!;
        public string? Nombres { get; set; } = null!;
        public string? Apellidos { get; set; } = null!;
        public string? Celular { get; set; } = null!;
        public string? Email { get; set; } = null!;
    }
}
