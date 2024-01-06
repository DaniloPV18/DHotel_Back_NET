using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DHotel_Back.DBContext.Config
{
    public class HuespedConfig : IEntityTypeConfiguration<Huesped>
    {
        public void Configure(EntityTypeBuilder<Huesped> builder)
        {
            builder
                .Property(h => h.AdministradorId)
                .IsRequired(false);
        }
    }
}
