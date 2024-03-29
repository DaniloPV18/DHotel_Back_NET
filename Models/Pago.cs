﻿namespace DHotel_Back.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public int? HabitacionId { get; set; }
        public Habitacion? Habitacion { get; set; } = null!;
        public int? AdministradorId { get; set; }
        public Administrador? Administrador { get; set; } = null!;
        public int? HuespedId { get; set; }
        public Huesped? Huesped { get; set; } = null!;
        public int? TipoPagoId { get; set; }
        public decimal? ValorPagado { get; set; }
        public decimal? ValorAPagar { get; set; }
        public string? ServiciosHabitacion { get; set; } = null!;
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? EstadoId { get; set; }
        public List<AbonoReserva>? AbonosReservas { get; set; } = new List<AbonoReserva>();
    }
}
