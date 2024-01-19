namespace DHotel_Back.DTOs.AdministradorDTO
{
    public class AdministradorDTO
    {
        public int Id { get; set; }
        public string? Cedula { get; set; } = null!;
        public string? Nombres { get; set; } = null!;
        public string? Apellidos { get; set; } = null!;
    }
}
