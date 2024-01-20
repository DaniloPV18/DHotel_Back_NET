using DHotel_Back.DTOs.PagoDTO;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Interfaces.Repository;
using DHotel_Back.Models;
using DHotel_Back.Services;
using Microsoft.AspNetCore.Mvc;

namespace DHotel_Back.Controllers
{
    [ApiController]
    [Route("api/v1/pago")]
    public class PagoController : ControllerBase
    {
        private readonly PagoService _pagoService;
        public PagoController(PagoService pagoService)
        {
            _pagoService = pagoService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PagoConsultaDTO>>> Get()
        {
            var serviciosOfrecidos = await this._pagoService.GetAll();
            return Ok(serviciosOfrecidos);
        }
        [HttpPost]
        public async Task<ActionResult> Post(PagoCreacionDTO entidad)
        {
            await this._pagoService.Add(entidad);
            return Ok();
        }
        [HttpPut("update")]
        public async Task<ActionResult> PutEntity(PagoModificacionDTO entidad)
        {
            var result = await _pagoService.Update(entidad);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
