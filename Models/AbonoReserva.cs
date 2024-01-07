namespace DHotel_Back.Models
{
    public class AbonoReserva
    {
        public int Id { get; set; }
        public int? PagoId { get; set; }
        public Pago? Pago { get; set; } = null!;
        public int? IdAdminRegistro { get; set; }
        public decimal? ValorPagado { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
