using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DHotel_Back.DBContext.Config
{
    public class HabitacionServicioOfrecidoConfig : IEntityTypeConfiguration<HabitacionServicioOfrecido>
    {
        public void Configure(EntityTypeBuilder<HabitacionServicioOfrecido> builder)
        {
            builder.HasKey(hso => new { hso.HabitacionId, hso.ServicioOfrecidoId });
        }
    }
}
