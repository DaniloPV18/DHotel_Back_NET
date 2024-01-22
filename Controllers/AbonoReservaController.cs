using DHotel_Back.DTOs.AbonoReservaDTO;
using DHotel_Back.DTOs.PagoDTO;
using DHotel_Back.Services;
using Microsoft.AspNetCore.Mvc;

namespace DHotel_Back.Controllers
{
    [ApiController]
    [Route("api/v1/reservas")]
    public class AbonoReservaController : ControllerBase
    {
        private readonly AbonoReservaService _abonoReservaService;
        public AbonoReservaController(AbonoReservaService abonoReservaService)
        {
            _abonoReservaService = abonoReservaService;
        }
        [HttpGet("pago/{idPago}")]
        public async Task<ActionResult<IEnumerable<AbonoReservaConsultaDTO>>> GetByPago(int idPago)
        {
            var abonosReservas = await _abonoReservaService.GetAllByPagoId(idPago);
            return Ok(abonosReservas);
        }
        [HttpPost]
        public async Task<ActionResult> Post(AbonoReservaCreacionDTO entidad)
        {
            var result = await _abonoReservaService.Add(entidad);
            return Ok(result);
        }
        [HttpPut("updateStatus")]
        public async Task<ActionResult<PagoDTO>> PutEntity(AbonoReservaModificacionDTO entidad)
        {           
            var result = await _abonoReservaService.UpdateStatus(entidad);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
