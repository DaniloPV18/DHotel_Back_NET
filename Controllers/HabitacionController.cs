using DHotel_Back.DTOs.HabitacionDTO;
using DHotel_Back.Services;
using Microsoft.AspNetCore.Mvc;

namespace DHotel_Back.Controllers
{
    [ApiController]
    [Route("api/v1/habitacion")]
    public class HabitacionController : ControllerBase
    {
        private readonly HabitacionService _habitacionService;

        public HabitacionController(HabitacionService _habitacionService)
        {
            this._habitacionService = _habitacionService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HabitacionConsultaDTO>>> GetAll()
        {
            var habitaciones = await _habitacionService.GetAll();
            return Ok(habitaciones);
        }
        [HttpGet("activates")]
        public async Task<ActionResult<IEnumerable<HabitacionConsultaDTO>>> GetAllActivates()
        {
            var habitaciones = await _habitacionService.GetAllActivates();
            return Ok(habitaciones);
        }
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<ActionResult> Post([FromForm] HabitacionCreacionDTO entidad)
        {
            await _habitacionService.Add(entidad);
            return Ok();
        }
        [HttpPut("update")]
        [Consumes("multipart/form-data")]
        public async Task<ActionResult> PutEntity([FromForm] HabitacionModificacionDTO entidad)
        {
            var result = await _habitacionService.Update(entidad);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
