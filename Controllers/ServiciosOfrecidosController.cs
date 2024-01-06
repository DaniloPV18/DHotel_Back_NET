using AutoMapper;
using DHotel_Back.DBContext;
using DHotel_Back.DTOs;
using DHotel_Back.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
