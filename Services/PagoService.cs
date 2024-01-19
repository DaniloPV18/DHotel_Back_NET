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
        public async Task Add(PagoCreacionDTO entidad)
        {
            var pago = _mapper.Map<Pago>(entidad);
            await _pagoRepository.AddAsync(pago);
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
    }
}
