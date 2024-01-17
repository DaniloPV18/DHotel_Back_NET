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
        public async Task<IEnumerable<Huesped>> GetAll()
        {
            return await this._huespedRepository.GetAllAsync();
        }
        public async Task<Huesped> GetById(int id)
        {
            return await this._huespedRepository.GetByIdAsync(id);
        }
        public async Task<IEnumerable<Huesped>> BuscarHuespedesPorNombre(string nombre)
        {
            return await this._huespedRepository.BuscarHuespedesPorNombre(nombre);
        }
        public async Task<IEnumerable<Huesped>> BuscarHuespedesPorNombreApellido(string palabra)
        {
            return await this._huespedRepository.BuscarHuespedesPorNombreApellidos(palabra);
        }
        public async Task Add(HuespedCreacionDTO entidad)
        {
            var administrador = _mapper.Map<Huesped>(entidad);
            await _huespedRepository.AddAsync(administrador);
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
