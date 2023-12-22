using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace DHotel_Back.Models
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int AdministradorId { get; set; }
        public Administrador Administrador { get; set; } = null!;
        public int TipoHabitacionId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int EstadoId { get; set; }
        public decimal Precio { get; set; }
        public string? Foto { get; set; }
        public List<Pago> Pagos { get; set; } = new List<Pago>();
        public List<HabitacionServicioOfrecido> HabitacionServicioOfrecido { get; set; } = new List<HabitacionServicioOfrecido>();
    }
}
