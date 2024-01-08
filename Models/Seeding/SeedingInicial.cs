using Microsoft.EntityFrameworkCore;

namespace DHotel_Back.Models.Seeding
{
    public class SeedingInicial
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var admin1 = new Administrador
            {
                Id = 1,
                Cedula = "0931600548",
                Nombres = "Micaela",
                Apellidos = "Zambrano",
                Celular = "0962723152",
                Email = "micaela@gmail.com",
                GeneroId = 2,
                Pwd = "0931600548",
                RolId = 1,
                EstadoId = 1,
                FechaRegistro = DateTime.Now
            };
            var admin2 = new Administrador
            {
                Id = 2,
                Cedula = "0931600549",
                Nombres = "Sonia",
                Apellidos = "Lasso",
                Celular = "0962723152",
                Email = "sonia@gmail.com",
                GeneroId = 2,
                Pwd = "0931600549",
                RolId = 2,
                EstadoId = 1,
                FechaRegistro = DateTime.Now
            };
            var admin3 = new Administrador
            {
                Id = 3,
                Cedula = "0931600550",
                Nombres = "Milo",
                Apellidos = "Marion",
                Celular = "0962723152",
                Email = "milo@gmail.com",
                GeneroId = 1,
                Pwd = "0931600550",
                RolId = 1,
                EstadoId = 1,
                FechaRegistro = DateTime.Now
            };
            modelBuilder.Entity<Administrador>()
                .HasData(admin1, admin2, admin3);

            var hs1 = new Huesped
            {
                Id = 1,
                Cedula = "0931600897",
                Nombres = "Keila",
                Apellidos = "Karita",
                Celular = "0962723152",
                Email = "Keila@gmail.com",
                GeneroId = 2,
                FechaRegistro = DateTime.Now
            };
            var hs2 = new Huesped
            {
                Id = 2,
                Cedula = "0931600898",
                Nombres = "Alejandro",
                Apellidos = "Alesso",
                Celular = "0962723152",
                Email = "Alejandro@gmail.com",
                GeneroId = 1,
                FechaRegistro = DateTime.Now
            };
            var hs3 = new Huesped
            {
                Id = 3,
                Cedula = "0931600899",
                Nombres = "Pepe",
                Apellidos = "Toala",
                Celular = "0962723152",
                Email = "Pepe@gmail.com",
                GeneroId = 1,
                FechaRegistro = DateTime.Now
            };
            modelBuilder.Entity<Huesped>()
                .HasData(hs1, hs2, hs3);

            var so1 = new ServicioOfrecido
            {
                Id = 1,
                Codigo = "NET",
                Nombre = "Internet",
                EstadoId = 1,
                FechaRegistro = DateTime.Now
            };
            var so2 = new ServicioOfrecido
            {
                Id = 2,
                Codigo = "TV",
                Nombre = "Television Cable",
                EstadoId = 1,
                FechaRegistro = DateTime.Now
            };
            var so3 = new ServicioOfrecido
            {
                Id = 3,
                Codigo = "AIR",
                Nombre = "Aire Acondicionado",
                EstadoId = 1,
                FechaRegistro = DateTime.Now
            };
            modelBuilder.Entity<ServicioOfrecido>()
                .HasData(so1, so2, so3);

            var hb1 = new Habitacion
            {
                Id = 1,
                Numero = 400,
                EstadoId = 1,
                FechaRegistro = DateTime.Now
            };
            var hb2 = new Habitacion
            {
                Id = 2,
                Numero = 401,
                EstadoId = 1,
                FechaRegistro = DateTime.Now
            };
            var hb3 = new Habitacion
            {
                Id = 3,
                Numero = 402,
                EstadoId = 1,
                FechaRegistro = DateTime.Now
            };
            modelBuilder.Entity<Habitacion>()
                .HasData(hb1, hb2, hb3);

            var hb1_so1 = new HabitacionServicioOfrecido
            {
                HabitacionId = hb1.Id,
                ServicioOfrecidoId = so1.Id,
                FechaRegistro = DateTime.Now
            };

            var hb1_so2 = new HabitacionServicioOfrecido
            {
                HabitacionId = hb1.Id,
                ServicioOfrecidoId = so2.Id,
                FechaRegistro = DateTime.Now
            };

            modelBuilder.Entity<HabitacionServicioOfrecido>()
                .HasData(hb1_so1, hb1_so2);

        }
    }
}
