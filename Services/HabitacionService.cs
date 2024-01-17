using AutoMapper;
using DHotel_Back.DTOs.HabitacionDTO;
using DHotel_Back.DTOs.HabitacionServicioOfrecidoCreacionDTO;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Interfaces.IServices;
using DHotel_Back.Interfaces.Repository;
using DHotel_Back.Models;

namespace DHotel_Back.Services
{
    public class HabitacionService
    {
        private readonly IHabitacionRepository _habitacionRepository;
        private readonly IServicioOfrecidoRepository _servicioOfrecidoRepository;
        private readonly IHabitacionServicioOfrecidoRepository _habitacionServicioOfrecidoRepository;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _fileStorageService;

        public HabitacionService(IHabitacionRepository habitacionRepository, IMapper mapper, IFileStorageService fileStorageService, IServicioOfrecidoRepository servicioOfrecidoRepository, IHabitacionServicioOfrecidoRepository habitacionServicioOfrecidoRepository)
        {
            _habitacionRepository = habitacionRepository;
            _servicioOfrecidoRepository = servicioOfrecidoRepository;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
            _habitacionServicioOfrecidoRepository = habitacionServicioOfrecidoRepository;
        }
        public async Task<IEnumerable<HabitacionConsultaDTO>> GetAll()
        {
            var habitaciones = await this._habitacionRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<HabitacionConsultaDTO>>(habitaciones);
        }
        public async Task Add(HabitacionCreacionDTO entidad)
        {
            var habitacion = _mapper.Map<Habitacion>(entidad);

            if (entidad.Foto != null)
            {
                habitacion.Foto = await _fileStorageService.GuardarArchivo(entidad.Foto, "ImagesGlobal");
            }
            foreach (var servicioId in entidad.HabitacionServicioOfrecido)
            {
                var servicioExistente = await _servicioOfrecidoRepository.GetByIdAsync(servicioId);
                if (servicioExistente != null)
                {
                    habitacion.HabitacionServicioOfrecido.Add(new HabitacionServicioOfrecido
                    {
                        ServicioOfrecido = servicioExistente,
                        FechaRegistro = DateTime.Now
                    });
                }
            }
            await _habitacionRepository.AddAsync(habitacion);
        }
        public async Task<bool> Update(HabitacionModificacionDTO entidad)
        {
            var existingEntity = await _habitacionRepository.GetByIdAsync(entidad.Id);
            if (existingEntity == null)
            {
                return false;
            }            
            if (entidad.Foto != null)
            {
                if(existingEntity.Foto != null)
                {
                    var existingFile = await _fileStorageService.BuscarArchivo(existingEntity.Foto, "ImagesGlobal");
                    if (existingFile != null)
                    {
                        await _fileStorageService.EliminarArchivo(existingEntity.Foto, "ImagesGlobal");
                        existingEntity.Foto = await _fileStorageService.GuardarArchivo(entidad.Foto, "ImagesGlobal");
                    }
                }
                else
                {
                    existingEntity.Foto = await _fileStorageService.GuardarArchivo(entidad.Foto, "ImagesGlobal");
                }                    
            }
            _mapper.Map(entidad, existingEntity);
            _habitacionRepository.Update(existingEntity);
            await _habitacionServicioOfrecidoRepository.EliminarRegistrosHabitacion(entidad.Id);
            foreach (var servicioId in entidad.HabitacionServicioOfrecido)
            {
                var servicioExistente = await _servicioOfrecidoRepository.GetByIdAsync(servicioId);
                if (servicioExistente != null)
                {
                    var habitacionServicioOfrecido = new HabitacionServicioOfrecidoCreacionDTO
                    {
                        HabitacionId = entidad.Id,
                        ServicioOfrecidoId = servicioId,
                    };                    
                    await _habitacionServicioOfrecidoRepository.AddAsync(_mapper.Map<HabitacionServicioOfrecido>(habitacionServicioOfrecido));
                }
            }
            await _habitacionRepository.SaveChangesAsync();
            return true;
        }
    }
}
