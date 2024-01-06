using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace DHotel_Back.DBContext.Config
{
    public class AdministradorConfig : IEntityTypeConfiguration<Administrador>
    {
        public void Configure(EntityTypeBuilder<Administrador> builder)
        {
            builder.Property(a => a.FechaNacimiento).HasColumnType("date");

            builder
               .Property(so => so.Pwd)
               .IsRequired(false);

        }
    }
}
