namespace DHotel_Back.DTOs.HabitacionDTO
{
    public class HabitacionDTO
    {
        public int Id { get; set; }
        public int? Numero { get; set; }
        public int? TipoHabitacionId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? EstadoId { get; set; }
        public decimal? Precio { get; set; }
        public string? Foto { get; set; }
        public List<HabitacionServicioOfrecidoDTO.HabitacionServicioOfrecidoDTO>? HabitacionServicioOfrecido { get; set; } = new List<HabitacionServicioOfrecidoDTO.HabitacionServicioOfrecidoDTO>();
    }
}
