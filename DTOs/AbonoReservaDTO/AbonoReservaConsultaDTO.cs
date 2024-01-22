namespace DHotel_Back.DTOs.AbonoReservaDTO
{
    public class AbonoReservaConsultaDTO
    {
        public int Id { get; set; }
        public AdministradorDTO.AdministradorDTO? Administrador { get; set; }
        public decimal? ValorPagado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? EstadoId { get; set; }
    }
}
