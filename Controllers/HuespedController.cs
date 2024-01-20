using DHotel_Back.DBContext;
using DHotel_Back.DTOs.HuespedDTO;
using DHotel_Back.Models;
using DHotel_Back.Services;
using Microsoft.AspNetCore.Mvc;

namespace DHotel_Back.Controllers
{
    [ApiController]
    [Route("api/v1/huesped")]
    public class HuespedController : ControllerBase
    {
        private readonly HuespedService _huespedService;
        public HuespedController(ApplicationDbContext context, HuespedService huespedService)
        {
            this._huespedService = huespedService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Huesped>>> GetAll()
        {
            var huespedes = await _huespedService.GetAll();
            return Ok(huespedes);
        }
        [HttpGet("BuscarPorNombresApellidos")]
        public async Task<ActionResult<IEnumerable<Huesped>>> GetNombresApellidos(string nombresApellidos)
        {
            var huespedes = await _huespedService.BuscarHuespedesPorNombreApellido(nombresApellidos);
            return Ok(huespedes);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Huesped>> GetId(int id)
        {
            var huesped = await _huespedService.GetById(id);
            if (huesped is null)
            {
                return NotFound();
            }
            return huesped;
        }
        [HttpPost]
        public async Task<ActionResult<HuespedDTO>> Post(HuespedCreacionDTO entidad)
        {
            var huesped = await _huespedService.Add(entidad);
            return Ok(huesped);
        }
        [HttpPut("update")]
        public async Task<ActionResult> PutEntity(HuespedModificacionDTO entidad)
        {
            var result = await _huespedService.Update(entidad);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
