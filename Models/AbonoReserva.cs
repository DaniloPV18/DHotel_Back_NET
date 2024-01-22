namespace DHotel_Back.Models
{
    public class AbonoReserva
    {
        public int Id { get; set; }
        public int? PagoId { get; set; }
        public Pago? Pago { get; set; } = null!;
        public int? AdministradorId { get; set; }
        public Administrador? Administrador { get; set; }
        public decimal? ValorPagado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? EstadoId { get; set; }
    }
}
