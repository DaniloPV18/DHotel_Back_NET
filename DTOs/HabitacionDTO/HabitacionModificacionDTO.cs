﻿using DHotel_Back.Utilidades.Validations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DHotel_Back.DTOs.HabitacionDTO
{
    public class HabitacionModificacionDTO
    {
        public HabitacionModificacionDTO()
        {
            FechaModificacion = DateTime.Now;
            HabitacionServicioOfrecido = new List<int>();
        }
        public int Id { get; set; }
        public int? Numero { get; set; }
        public int? AdministradorId { get; set; }
        public int? TipoHabitacionId { get; set; }
        [BindNever]
        public DateTime FechaModificacion { get; set; }
        public int EstadoId { get; set; }
        public decimal? Precio { get; set; }
        [PesoArchivoValidacion(PesoMaximoEnMegaBytes: 100)]
        [TipoArchivoValidacion(GrupoTipoArchivo.Imagen)]
        public IFormFile? Foto { get; set; }
        public List<int>? HabitacionServicioOfrecido { get; set; }
    }
}
