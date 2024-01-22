using AutoMapper;
using DHotel_Back.DTOs.AbonoReservaDTO;
using DHotel_Back.DTOs.PagoDTO;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;

namespace DHotel_Back.Services
{
    public class AbonoReservaService
    {
        private readonly IAbonoReservaRepository _abonoReservaRepository;
        private readonly IPagoRepository _pagoRepository;
        private readonly IMapper _mapper;

        public AbonoReservaService(IAbonoReservaRepository abonoReservaRepository, IMapper mapper, IPagoRepository pagoRepository)
        {
            _abonoReservaRepository = abonoReservaRepository;
            _mapper = mapper;
            _pagoRepository = pagoRepository;
        }
        public async Task<IEnumerable<AbonoReservaConsultaDTO>> GetAllByPagoId(int idPago)
        {
            var abonosReserva = await _abonoReservaRepository.GetAllAsyncByPagoId(idPago);
            return _mapper.Map<IEnumerable<AbonoReservaConsultaDTO>>(abonosReserva);
        }
        public async Task<bool> Add(AbonoReservaCreacionDTO entidad)
        {
            var abonoReserva = _mapper.Map<AbonoReserva>(entidad);
            var sumatoria = await _abonoReservaRepository.GetSumReserva(entidad.PagoId);
            var pagoPadre = await _pagoRepository.GetByIdAsync(entidad.PagoId);
            var totalAbonado = abonoReserva.ValorPagado + sumatoria;
            if (totalAbonado > pagoPadre.ValorAPagar)
            {
                return false;
            }
            pagoPadre.ValorPagado = totalAbonado;
            var pendiente = pagoPadre.ValorAPagar - pagoPadre.ValorPagado;
            if (pendiente == 0)
            {
                pagoPadre.EstadoId = 1;
            }
            else
            {
                pagoPadre.EstadoId = 2;
            }
            await _abonoReservaRepository.AddAsync(abonoReserva);
            _pagoRepository.Update(pagoPadre);
            await _pagoRepository.SaveChangesAsync();
            return true;
        }
        public async Task<PagoDTO> UpdateStatus(AbonoReservaModificacionDTO entidad)
        {
            var existingEntity = await _abonoReservaRepository.GetByIdAsync(entidad.Id);
            if (existingEntity == null)
            {
                return null;
            }
            var sumatoria = await _abonoReservaRepository.GetSumReserva(entidad.PagoId);
            var pagoPadre = await _pagoRepository.GetByIdAsync(entidad.PagoId);
            var pendiente = pagoPadre.ValorAPagar - pagoPadre.ValorPagado;
            pagoPadre.ValorPagado = sumatoria;
            existingEntity.EstadoId = 3;
            _abonoReservaRepository.Update(existingEntity);
            await _abonoReservaRepository.SaveChangesAsync();
            var verificarEstadoPago = await _abonoReservaRepository.VerificarSiTodasEstanAnuladas(entidad.PagoId);
            if (pendiente == 0)
            {
                pagoPadre.EstadoId = 1;
            }
            else if (verificarEstadoPago)
            {
                pagoPadre.EstadoId = 3;
                pagoPadre.ValorPagado = 0;
            }
            else
            {
                pagoPadre.EstadoId = 2;
            }
            _pagoRepository.Update(pagoPadre);
            await _pagoRepository.SaveChangesAsync();
            return _mapper.Map<PagoDTO>(pagoPadre);
        }
    }
}
