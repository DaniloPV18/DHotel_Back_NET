using AutoMapper;
using DHotel_Back.DBContext;
using DHotel_Back.DTOs;
using DHotel_Back.Models;
using DHotel_Back.Services;
using DHotel_Back.Utilidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<IEnumerable<Habitacion>>> GetAll()
        {
            var habitaciones = await _habitacionService.GetAll();
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
            //var result = await _habitacionService.Update(entidad);
            //if (!result)
            //{
            //    return NotFound();
            //}
            return Ok();
        }
    }
}
