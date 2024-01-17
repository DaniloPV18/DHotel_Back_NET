using DHotel_Back.DTOs.ServicioOfrecidoDTO;
using DHotel_Back.Models;
using DHotel_Back.Services;
using Microsoft.AspNetCore.Mvc;

namespace DHotel_Back.Controllers
{
    [ApiController]
    [Route("api/v1/serviciosofrecidos")]
    public class ServiciosOfrecidosController : ControllerBase
    {

        private readonly ServicioOfrecidoService _servicioOfrecidoRepository;
        public ServiciosOfrecidosController(ServicioOfrecidoService servicioOfrecidoRepository)
        {
            this._servicioOfrecidoRepository = servicioOfrecidoRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServicioOfrecido>>> GetAll()
        {
            var serviciosOfrecidos = await this._servicioOfrecidoRepository.GetAll();
            return Ok(serviciosOfrecidos);
        }
        [HttpGet("activates")]
        public async Task<ActionResult<IEnumerable<ServicioOfrecido>>> GetAllActivates()
        {
            var serviciosOfrecidos = await this._servicioOfrecidoRepository.BuscarServiciosActivos();
            return Ok(serviciosOfrecidos);
        }
        [HttpPost]
        public async Task<ActionResult> Post(ServicioOfrecidoCreacionDTO entidad)
        {
            await _servicioOfrecidoRepository.Add(entidad);
            return Ok();
        }
        [HttpPost("varios")]
        public async Task<ActionResult> PostSome(ServicioOfrecidoCreacionDTO[] entidades)
        {
            await _servicioOfrecidoRepository.AddSome(entidades);
            return Ok();
        }
        [HttpPut("update")]
        public async Task<ActionResult> PutEntity(ServicioOfrecidoModificacionDTO entidad)
        {
            var result = await _servicioOfrecidoRepository.Update(entidad);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
