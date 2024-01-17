using AutoMapper;
using DHotel_Back.DTOs.ServicioOfrecidoDTO;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;

namespace DHotel_Back.Services
{
    public class ServicioOfrecidoService
    {
        private readonly IServicioOfrecidoRepository _servicioOfrecidoRepository;
        private readonly IMapper _mapper;

        public ServicioOfrecidoService(IServicioOfrecidoRepository huespedRepository, IMapper mapper)
        {
            _servicioOfrecidoRepository = huespedRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ServicioOfrecido>> GetAll()
        {
            return await this._servicioOfrecidoRepository.GetAllAsync();
        }
        public async Task<ServicioOfrecido> GetById(int id)
        {
            return await this._servicioOfrecidoRepository.GetByIdAsync(id);
        }
        public async Task<IEnumerable<ServicioOfrecido>> BuscarServiciosActivos()
        {
            return await this._servicioOfrecidoRepository.BuscarServiciosActivos();
        }
        public async Task Add(ServicioOfrecidoCreacionDTO entidad)
        {
            var administrador = _mapper.Map<ServicioOfrecido>(entidad);
            await _servicioOfrecidoRepository.AddAsync(administrador);
        }
        public async Task AddSome(ServicioOfrecidoCreacionDTO[] entidad)
        {
            var administrador = _mapper.Map<ServicioOfrecido[]>(entidad);
            await _servicioOfrecidoRepository.AddRange(administrador);
        }
        public async Task<bool> Update(ServicioOfrecidoModificacionDTO entidad)
        {
            var existingEntity = await _servicioOfrecidoRepository.GetByIdAsync(entidad.Id);
            if (existingEntity == null)
            {
                return false;
            }
            _mapper.Map(entidad, existingEntity);
            _servicioOfrecidoRepository.Update(existingEntity);
            await _servicioOfrecidoRepository.SaveChangesAsync();
            return true;
        }
    }
}
