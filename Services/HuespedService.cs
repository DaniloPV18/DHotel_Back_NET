using AutoMapper;
using DHotel_Back.DTOs.HuespedDTO;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;

namespace DHotel_Back.Services
{
    public class HuespedService
    {
        private readonly IHuespedRepository _huespedRepository;
        private readonly IMapper _mapper;

        public HuespedService(IHuespedRepository huespedRepository, IMapper mapper)
        {
            _huespedRepository = huespedRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<HuespedConsultaDTO>> GetAll()
        {
            var huespedes = await this._huespedRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<HuespedConsultaDTO>>(huespedes);
        }
        public async Task<Huesped> GetById(int id)
        {
            return await this._huespedRepository.GetByIdAsync(id);
        }
        public async Task<IEnumerable<HuespedConsultaDTO>> BuscarHuespedesPorNombre(string nombre)
        {
            var huespedes = await this._huespedRepository.BuscarHuespedesPorNombre(nombre);
            return _mapper.Map<IEnumerable<HuespedConsultaDTO>>(huespedes);
        }
        public async Task<IEnumerable<HuespedConsultaDTO>> BuscarHuespedesPorNombreApellido(string palabra)
        {
            var huespedes = await this._huespedRepository.BuscarHuespedesPorNombreApellidos(palabra);
            return _mapper.Map<IEnumerable<HuespedConsultaDTO>>(huespedes);
        }
        public async Task<HuespedDTO> Add(HuespedCreacionDTO entidad)
        {
            var huesped = _mapper.Map<Huesped>(entidad);
            await _huespedRepository.AddAsync(huesped);
            await _huespedRepository.SaveChangesAsync();
            return _mapper.Map<HuespedDTO>(huesped);
        }
        public async Task<bool> Update(HuespedModificacionDTO entidad)
        {
            var existingEntity = await _huespedRepository.GetByIdAsync(entidad.Id);
            if (existingEntity == null)
            {
                return false;
            }
            _mapper.Map(entidad, existingEntity);
            _huespedRepository.Update(existingEntity);
            await _huespedRepository.SaveChangesAsync();
            return true;
        }
    }
}
