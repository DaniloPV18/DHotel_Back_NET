using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace DHotel_Back.DBContext.Config
{
    public class ServicioOfrecidoConfig : IEntityTypeConfiguration<ServicioOfrecido>
    {
        public void Configure(EntityTypeBuilder<ServicioOfrecido> builder)
        {
            builder
                .HasOne(so => so.Administrador)
                .WithMany(a => a.ServicioOfrecido)
                .HasForeignKey(so => so.AdministradorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
