namespace DHotel_Back.Models
{
    public class HabitacionServicioOfrecido
    {
        public int HabitacionId { get; set; }
        public Habitacion Habitacion { get; set; } = null!;
        public int ServicioOfrecidoId { get; set; }
        public ServicioOfrecido ServicioOfrecido { get; set; } = null!;
        public DateTime FechaRegistro { get; set; }
    }
}
