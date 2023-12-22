using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DHotel_Back.DBContext.Config
{
    public class HabitacionConfig : IEntityTypeConfiguration<Habitacion>
    {
        public void Configure(EntityTypeBuilder<Habitacion> builder)
        {
            builder.Property(a => a.Precio).HasPrecision(5, 2);
        }
    }
}
