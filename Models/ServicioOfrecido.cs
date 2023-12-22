namespace DHotel_Back.Models
{
    public class ServicioOfrecido
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int AdministradorId { get; set; }
        public Administrador Administrador { get; set; } = null!;
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int IdEstado { get; set; }
        public List<HabitacionServicioOfrecido> HabitacionServicioOfrecido { get; set; } = new List<HabitacionServicioOfrecido>();
    }
}
