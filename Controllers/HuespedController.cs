using AutoMapper;
using DHotel_Back.DBContext;
using DHotel_Back.DTOs;
using DHotel_Back.Models;
using Microsoft.AspNetCore.Mvc;

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
        [HttpPost]
        public async Task<ActionResult> Post(HuespedCreacionDTO entidad)
        {
            this.context.Add(this.mapper.Map<Huesped>(entidad));
            await this.context.SaveChangesAsync();
            return Ok();
        }
    }
}
