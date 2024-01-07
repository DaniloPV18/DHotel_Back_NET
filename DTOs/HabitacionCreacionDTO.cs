﻿using DHotel_Back.Models;
using DHotel_Back.Validaciones;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.Json.Serialization;

namespace DHotel_Back.DTOs
{
    public class HabitacionCreacionDTO
    {
        public HabitacionCreacionDTO()
        {
            FechaRegistro = DateTime.Now;
            EstadoId = 1;
            HabitacionServicioOfrecido = new List<int>();
        }
        public int? Numero { get; set; }
        public int? AdministradorId { get; set; }
        public int? TipoHabitacionId { get; set; }
        [BindNever]
        public DateTime FechaRegistro { get; set; }
        [BindNever]
        public int EstadoId { get; set; }
        public decimal? Precio { get; set; }
        [PesoArchivoValidacion(PesoMaximoEnMegaBytes:100)]
        [TipoArchivoValidacion(GrupoTipoArchivo.Imagen)]
        public IFormFile? Foto { get; set; }
        public List<int>? HabitacionServicioOfrecido { get; set; }
    }
}
