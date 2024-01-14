using DHotel_Back.DTOs;
using DHotel_Back.Models;
using DHotel_Back.Services;
using Microsoft.AspNetCore.Mvc;

namespace DHotel_Back.Controllers
{
    [ApiController]
    [Route("api/v1/administrador")]
    public class AdministradorController : ControllerBase
    {
        private readonly AdministradorService _administradorService;
        public AdministradorController(AdministradorService administradorService)
        {
            this._administradorService = administradorService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Administrador>>> GetAll()
        {
            var administradores = await _administradorService.GetAll();
            return Ok(administradores);
        }
        [HttpPost]
        public async Task<ActionResult> Post(AdministradorCreacionDTO entidad)
        {
            await _administradorService.Add(entidad);
            return Ok();
        }
        [HttpPut("update")]
        public async Task<ActionResult<Administrador>> PutEntity(AdministradorModificacionDTO entidad)
        {
            var result = await _administradorService.Update(entidad);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
