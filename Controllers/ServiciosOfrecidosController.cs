using AutoMapper;
using DHotel_Back.DBContext;
using DHotel_Back.DTOs;
using DHotel_Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DHotel_Back.Controllers
{
    [ApiController]
    [Route("api/v1/serviciosofrecidos")]
    public class ServiciosOfrecidosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        public ServiciosOfrecidosController(ApplicationDbContext _context, IMapper _mapper)
        {
            this.context = _context;
            this.mapper = _mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServicioOfrecido>>> GetAll()
        {
            return await this.context.ServiciosOfrecidos.ToListAsync();
        }
        [HttpGet("activates")]
        public async Task<ActionResult<IEnumerable<ServicioOfrecido>>> GetAllActivates()
        {
            return await this.context.ServiciosOfrecidos.Where(so => so.EstadoId == 1).ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult> Post(ServicioOfrecidoCreacionDTO entidad)
        {
            this.context.Add(this.mapper.Map<ServicioOfrecido>(entidad));
            await this.context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost("varios")]
        public async Task<ActionResult> Post(ServicioOfrecidoCreacionDTO[] entidades)
        {
            this.context.AddRange(this.mapper.Map<ServicioOfrecido[]>(entidades));
            await this.context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("update")]
        public async Task<ActionResult> PutEntity(ServicioOfrecidoModificacionDTO entidad)
        {
            var existingEntity = await this.context.ServiciosOfrecidos.FirstOrDefaultAsync(a => a.Id == entidad.Id);
            if (existingEntity == null)
            {
                return NotFound();
            }
            this.mapper.Map(entidad, existingEntity);
            await this.context.SaveChangesAsync();
            return Ok();
        }
    }
}
