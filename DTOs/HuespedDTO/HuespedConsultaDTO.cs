using DHotel_Back.DTOs.AdministradorDTO;
using DHotel_Back.DTOs.PagoDTO;

namespace DHotel_Back.DTOs.HuespedDTO
{
    public class HuespedConsultaDTO
    {
        public int Id { get; set; }
        public string? Cedula { get; set; } = null!;
        public string? Nombres { get; set; } = null!;
        public string? Apellidos { get; set; } = null!;
        public string? Celular { get; set; } = null!;
        public string? Email { get; set; } = null!;
        public int? GeneroId { get; set; }
        public AdministradorConsultaDTO? Administrador { get; set; } = null!;
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public List<PagoConsultaDTO>? Pago { get; set; } = new List<PagoConsultaDTO>();
    }
}
