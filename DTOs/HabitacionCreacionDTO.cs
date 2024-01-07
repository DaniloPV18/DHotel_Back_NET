using DHotel_Back.Models;
using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs
{
    public class HabitacionCreacionDTO
    {
        public HabitacionCreacionDTO()
        {
            FechaRegistro = DateTime.Now;
            EstadoId = 1;
        }
        public int? Numero { get; set; }
        public int? AdministradorId { get; set; }
        public int? TipoHabitacionId { get; set; }
        [JsonIgnore]
        public DateTime? FechaRegistro { get; set; } 
        [JsonIgnore]
        public int? EstadoId { get; set; }
        public decimal? Precio { get; set; }
        public string? Foto { get; set; }
        public List<int>? HabitacionServicioOfrecido { get; set; } = new List<int>();
    }
}
