using DHotel_Back.Models;
using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs
{
    public class HabitacionServicioOfrecidoCreacionDTO
    {
        public HabitacionServicioOfrecidoCreacionDTO()
        {
            FechaRegistro = DateTime.Now;
        }
        public int? HabitacionId { get; set; }
        public int? ServicioOfrecidoId { get; set; }
        [JsonIgnore]
        public DateTime? FechaRegistro { get; set; }
    }
}
