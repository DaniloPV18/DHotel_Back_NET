namespace DHotel_Back.Models
{
    public class Huesped
    {
        public int Id { get; set; }
        public string? Cedula { get; set; } = null!;
        public string? Nombres { get; set; } = null!;
        public string? Apellidos { get; set; } = null!;
        public string? Celular { get; set; } = null!;
        public string? Email { get; set; } = null!;
        public int? GeneroId { get; set; }
        public int? AdministradorId { get; set; }
        public Administrador? Administrador { get; set; } = null!;
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public List<Pago>? Pagos { get; set; } = new List<Pago>();
    }
}
