using DHotel_Back.DTOs.AdministradorDTO;
using DHotel_Back.DTOs.HabitacionServicioOfrecidoCreacionDTO;
using DHotel_Back.DTOs.PagoDTO;

namespace DHotel_Back.DTOs.HabitacionDTO
{
    public class HabitacionConsultaDTO
    {
        public int Id { get; set; }
        public int? Numero { get; set; }
        public AdministradorConsultaDTO? Administrador { get; set; } = null!;
        public int? TipoHabitacionId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? EstadoId { get; set; }
        public decimal? Precio { get; set; }
        public string? Foto { get; set; }
        public List<PagoConsultaDTO>? Pagos { get; set; } = new List<PagoConsultaDTO>();
        public List<HabitacionServicioOfrecidoConsultaDTO>? HabitacionServicioOfrecido { get; set; } = new List<HabitacionServicioOfrecidoConsultaDTO>();
    }
}
