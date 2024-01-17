using DHotel_Back.DTOs.ServicioOfrecidoDTO;

namespace DHotel_Back.DTOs.HabitacionServicioOfrecidoCreacionDTO
{
    public class HabitacionServicioOfrecidoConsultaDTO
    {
        public int? HabitacionId { get; set; }
        public int? ServicioOfrecidoId { get; set; }
        public ServicioOfrecidoConsultaDTO? ServicioOfrecido { get; set; } = null!;
        public DateTime? FechaRegistro { get; set; }
    }
}
