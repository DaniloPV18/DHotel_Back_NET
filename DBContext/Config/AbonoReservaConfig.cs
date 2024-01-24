using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DHotel_Back.DBContext.Config
{
    public class AbonoReservaConfig : IEntityTypeConfiguration<AbonoReserva>
    {
        public void Configure(EntityTypeBuilder<AbonoReserva> builder)
        {
            builder.Property(a => a.ValorPagado).HasPrecision(10, 2);
        }
    }
}
