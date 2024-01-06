namespace DHotel_Back.DTOs
{
    public class ServicioOfrecidoCreacionDTO
    {
        public ServicioOfrecidoCreacionDTO()
        {
            FechaRegistro = DateTime.Now;
            EstadoId = 1;
        }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int? AdministradorId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? EstadoId { get; set; }
    }
}
