namespace DHotel_Back.DTOs.HuespedDTO
{
    public class HuespedDTO
    {
        public int Id { get; set; }
        public string? Cedula { get; set; } = null!;
        public string? Nombres { get; set; } = null!;
        public string? Apellidos { get; set; } = null!;
    }
}
