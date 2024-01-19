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
        public int? GeneroId { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? RolId { get; set; }
        public int? EstadoId { get; set; }
        public DateTime? UltimaActividad { get; set; }
    }
}
