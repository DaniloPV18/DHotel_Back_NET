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
        public async Task<IEnumerable<ServicioOfrecidoConsultaDTO>> GetAll()
        {
            var serviciosOfrecidos = await this._servicioOfrecidoRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ServicioOfrecidoConsultaDTO>>(serviciosOfrecidos);
        }
        public async Task<ServicioOfrecidoConsultaDTO> GetById(int id)
        {
            var servicioOfrecido = await this._servicioOfrecidoRepository.GetByIdAsync(id);
            return _mapper.Map<ServicioOfrecidoConsultaDTO>(servicioOfrecido);
        }
        public async Task<IEnumerable<ServicioOfrecidoConsultaDTO>> BuscarServiciosActivos()
        {
            var serviciosOfrecidos = await this._servicioOfrecidoRepository.BuscarServiciosActivos();
            return _mapper.Map<IEnumerable<ServicioOfrecidoConsultaDTO>>(serviciosOfrecidos);
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
