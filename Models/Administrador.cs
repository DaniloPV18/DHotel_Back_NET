using DHotel_Back.DBContext.Config;

namespace DHotel_Back.Models
{
    public class Administrador
    {
        public int Id { get; set; }
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
        public DateTime? FechaRegistro { get; set; }
        public int? EstadoId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? UltimaActividad { get; set; }
        public HashSet<Habitacion>? Habitaciones { get; set; } = new HashSet<Habitacion>();
        //public HashSet<Huesped> Huespedes { get; set; } = new HashSet<Huesped>();
        //public List<Pago>? Pagos { get; set; } = new List<Pago>();
        public HashSet<ServicioOfrecido>? ServicioOfrecido { get; set; } = new HashSet<ServicioOfrecido>();
    }
}
