namespace DHotel_Back.DTOs.ServicioOfrecidoDTO
{
    public class ServicioOfrecidoConsultaDTO
    {
        public int Id { get; set; }
        public string? Codigo { get; set; } = null!;
        public string? Nombre { get; set; } = null!;
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? EstadoId { get; set; }
    }
}
