using DHotel_Back.Models;
using DHotel_Back.Models.Seeding;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DHotel_Back.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedingInicial.Seed(modelBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(150);
        }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Huesped> Huespedes { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<ServicioOfrecido> ServiciosOfrecidos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<AbonoReserva> AbonosReservas { get; set; }
    }
}
