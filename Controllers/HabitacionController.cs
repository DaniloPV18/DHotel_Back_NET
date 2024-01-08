using AutoMapper;
using DHotel_Back.DBContext;
using DHotel_Back.DTOs;
using DHotel_Back.Models;
using DHotel_Back.Utilidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DHotel_Back.Controllers
{
    [ApiController]
    [Route("api/v1/habitacion")]
    public class HabitacionController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public HabitacionController(ApplicationDbContext _context, IMapper _mapper)
        {
            this.context = _context;
            this.mapper = _mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Habitacion>>> GetAll()
        {
            return await this.context.Habitaciones.ToListAsync();
        }
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<ActionResult> Post([FromForm] HabitacionCreacionDTO entidad)
        {
            var habitacion = mapper.Map<Habitacion>(entidad);
            if (entidad.Foto != null)
            {
                var rutaFoto = await Images.GuardarArchivo(entidad.Foto);
                habitacion.Foto = rutaFoto;
            }
            foreach (var servicioId in entidad.HabitacionServicioOfrecido)
            {
                var servicioExistente = await context.ServiciosOfrecidos.FindAsync(servicioId);
                if (servicioExistente != null)
                {
                    habitacion.HabitacionServicioOfrecido
                        .Add(new HabitacionServicioOfrecido
                        {
                            ServicioOfrecido = servicioExistente,
                            FechaRegistro = DateTime.Now
                        }
                        );
                }
            }
            context.Habitaciones.Add(habitacion);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
