using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs.AbonoReservaDTO
{
    public class AbonoReservaCreacionDTO
    {
        public AbonoReservaCreacionDTO()
        {
            FechaRegistro = DateTime.Now;
            EstadoId = 1;
        }
        public int PagoId { get; set; }
        public int? AdministradorId { get; set; }
        public decimal? ValorPagado { get; set; }
        [JsonIgnore]
        public DateTime? FechaRegistro { get; set; }
        [JsonIgnore]
        public int? EstadoId { get; set; }
    }
}
