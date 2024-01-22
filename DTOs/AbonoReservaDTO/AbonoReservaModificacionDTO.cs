using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs.AbonoReservaDTO
{
    public class AbonoReservaModificacionDTO
    {
        public AbonoReservaModificacionDTO()
        {
            FechaModificacion = DateTime.Now;
        }
        public int Id { get; set; }
        public int PagoId { get; set; }
        public int? AdministradorId { get; set; }
        public decimal? ValorPagado { get; set; }
        [JsonIgnore]
        public DateTime? FechaModificacion { get; set; }
        public int? EstadoId { get; set; }
    }
}
