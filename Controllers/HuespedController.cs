using AutoMapper;
using DHotel_Back.DBContext;
using DHotel_Back.DTOs;
using DHotel_Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DHotel_Back.Controllers
{
    [ApiController]
    [Route("api/v1/huesped")]
    public class HuespedController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        public HuespedController(ApplicationDbContext _context, IMapper _mapper)
        {
            this.context = _context;
            this.mapper = _mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Huesped>>> GetAll()
        {
            return await this.context.Huespedes
                .ToArrayAsync();
        }
        [HttpGet("BuscarPorNombresApellidos")]
        public async Task<ActionResult<IEnumerable<Huesped>>> GetNombresApellidos(string nombresApellidos)
        {
            return await this.context.Huespedes
                .Where(h => h.Nombres.Contains(nombresApellidos) || h.Apellidos.Contains(nombresApellidos))
                .ToArrayAsync();
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Huesped>> GetId(int id)
        {
            var huesped = await this.context.Huespedes.FirstOrDefaultAsync(h => h.Id == id);
            if (huesped is null)
                return NotFound();
            return huesped;
        }
        [HttpPost]
        public async Task<ActionResult> Post(HuespedCreacionDTO entidad)
        {
            this.context.Add(this.mapper.Map<Huesped>(entidad));
            await this.context.SaveChangesAsync();
            return Ok();
        }
    }
}
