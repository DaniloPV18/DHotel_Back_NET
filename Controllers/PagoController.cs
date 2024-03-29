﻿using DHotel_Back.DTOs.PagoDTO;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Interfaces.Repository;
using DHotel_Back.Models;
using DHotel_Back.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DHotel_Back.Controllers
{
    [Authorize]
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
            var pagos = await this._pagoService.GetAll();
            return Ok(pagos);
        }
        [HttpPost]
        public async Task<ActionResult<PagoDTO>> Post(PagoCreacionDTO entidad)
        {
            var pagoAgregado = await this._pagoService.Add(entidad);
            return Ok(pagoAgregado);
        }
        [HttpPost("available")]
        public async Task<ActionResult> PostAvailable(PagoCreacionDTO entidad)
        {
            var pagos = await this._pagoService.GetAvailable(entidad);
            return Ok(pagos);
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
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeleteEntity(int id)
        {
            var result = await _pagoService.Delete(id);
            if (!result)
            {
                return NotFound();
            }
            return Ok();
        }

    }
}
