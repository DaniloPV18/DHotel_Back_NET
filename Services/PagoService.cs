using AutoMapper;
using DHotel_Back.DTOs.PagoDTO;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;

namespace DHotel_Back.Services
{
    public class PagoService
    {
        private readonly IPagoRepository _pagoRepository;
        private readonly IMapper _mapper;
        public PagoService(IPagoRepository pagoRepository, IMapper mapper)
        {
            _pagoRepository = pagoRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PagoConsultaDTO>> GetAll()
        {
            var pagos = await this._pagoRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<PagoConsultaDTO>>(pagos);
        }
        public async Task<IEnumerable<PagoConsultaDTO>> GetAvailable(PagoCreacionDTO entidad)
        {
            var pago = _mapper.Map<Pago>(entidad);
            var pagos = await this._pagoRepository.GetAvailableAsync(pago);
            return _mapper.Map<IEnumerable<PagoConsultaDTO>>(pagos);
        }        
        public async Task<PagoDTO> Add(PagoCreacionDTO entidad)
        {
            var pago = _mapper.Map<Pago>(entidad);
            await _pagoRepository.AddAsync(pago);
            var pagoRegistrado = _mapper.Map<PagoDTO>(pago);
            return pagoRegistrado;
        }
        public async Task<bool> Update(PagoModificacionDTO entidad)
        {
            var existingEntity = await _pagoRepository.GetByIdAsync(entidad.Id);
            if (existingEntity == null)
            {
                return false;
            }
            _mapper.Map(entidad, existingEntity);
            _pagoRepository.Update(existingEntity);
            await _pagoRepository.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Delete(int id)
        {
            var existingEntity = await _pagoRepository.GetByIdAsync(id);
            if (existingEntity == null)
            {
                return false;
            }
            existingEntity.EstadoId = 3;
            existingEntity.FechaModificacion = DateTime.Now;
            _pagoRepository.Update(existingEntity);
            await _pagoRepository.SaveChangesAsync();
            return true;
        }
    }
}
