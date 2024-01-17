using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs.HabitacionServicioOfrecidoCreacionDTO
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
