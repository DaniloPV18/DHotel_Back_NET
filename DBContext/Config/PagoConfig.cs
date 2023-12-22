using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DHotel_Back.DBContext.Config
{
    public class PagoConfig : IEntityTypeConfiguration<Pago>
    {
        public void Configure(EntityTypeBuilder<Pago> builder)
        {
            builder.Property(a => a.ValorAPagar).HasPrecision(5, 2);
            builder.Property(a => a.ValorPagado).HasPrecision(5, 2);
            builder.Property(a => a.FechaInicio).HasColumnType("date");
            builder.Property(a => a.FechaFin).HasColumnType("date");

            builder
                .HasOne(h => h.Habitacion)
                .WithMany(p => p.Pagos)
                .HasForeignKey(h => h.HabitacionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(h => h.Huesped)
                .WithMany(p => p.Pagos)
                .HasForeignKey(h => h.HuespedId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
