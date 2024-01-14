using AutoMapper;
using DHotel_Back.DBContext;
using DHotel_Back.DTOs;
using DHotel_Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DHotel_Back.Controllers
{
    [ApiController]
    [Route("api/v1/administrador")]
    public class AdministradorController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        public AdministradorController(ApplicationDbContext _context, IMapper _mapper)
        {
            this.context = _context;
            this.mapper = _mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Administrador>>> GetAll()
        {
            return await this.context.Administradores.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult> Post(AdministradorCreacionDTO entidad)
        {
            this.context.Add(this.mapper.Map<Administrador>(entidad));
            await this.context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("update")]
        public async Task<ActionResult<Administrador>> PutEntity(AdministradorModificacionDTO entidad)
        {
            var existingEntity = await this.context.Administradores.FirstOrDefaultAsync(a => a.Id == entidad.Id);
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
