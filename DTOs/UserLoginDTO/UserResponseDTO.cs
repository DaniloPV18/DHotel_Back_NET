namespace DHotel_Back.DTOs.UserLoginDTO
{
    public class UserResponseDTO
    {
        public int Id { get; set; }
        public string? Cedula { get; set; } = null!;
        public string? Nombres { get; set; } = null!;
        public string? Apellidos { get; set; } = null!;
        public int? RolId { get; set; }
        public string? Token { get; set; } = null!;
    }
}
