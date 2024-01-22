using AutoMapper;
using DHotel_Back.DTOs.AdministradorDTO;
using DHotel_Back.DTOs.UserLoginDTO;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;

namespace DHotel_Back.Services
{
    public class AdministradorService
    {
        private readonly IAdministradorRepository _administradorRepository;
        private readonly IMapper _mapper;

        public AdministradorService(IAdministradorRepository administradorRepository, IMapper mapper)
        {
            _administradorRepository = administradorRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AdministradorConsultaDTO>> GetAll()
        {
            var administradores = await this._administradorRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<AdministradorConsultaDTO>>(administradores);
        }
        public async Task Add(AdministradorCreacionDTO entidad)
        {
            var administrador = _mapper.Map<Administrador>(entidad);
            entidad.Pwd = BCrypt.Net.BCrypt.HashPassword(entidad.Cedula);
            await _administradorRepository.AddAsync(administrador);
        }
        public async Task<bool> Update(AdministradorModificacionDTO entidad)
        {
            var existingEntity = await _administradorRepository.GetByIdAsync(entidad.Id);
            if (existingEntity == null)
            {
                return false;
            }
            _mapper.Map(entidad, existingEntity);
            _administradorRepository.Update(existingEntity);
            await _administradorRepository.SaveChangesAsync();
            return true;
        }
    }
}
