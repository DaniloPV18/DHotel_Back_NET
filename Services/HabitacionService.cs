using AutoMapper;
using DHotel_Back.DTOs.HabitacionDTO;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Interfaces.IServices;
using DHotel_Back.Models;

namespace DHotel_Back.Services
{
    public class HabitacionService
    {
        private readonly IHabitacionRepository _habitacionRepository;
        private readonly IServicioOfrecidoRepository _servicioOfrecidoRepository;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _fileStorageService;

        public HabitacionService(IHabitacionRepository habitacionRepository, IMapper mapper, IFileStorageService fileStorageService, IServicioOfrecidoRepository servicioOfrecidoRepository)
        {
            _habitacionRepository = habitacionRepository;
            _servicioOfrecidoRepository = servicioOfrecidoRepository;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
        }
        public async Task<IEnumerable<HabitacionConsultaDTO>> GetAll()
        {
            var habitaciones = await this._habitacionRepository.ConsultarRelaciones();
            return _mapper.Map<IEnumerable<HabitacionConsultaDTO>>(habitaciones);
        }
        public async Task Add(HabitacionCreacionDTO habitacionDto)
        {
            var habitacion = _mapper.Map<Habitacion>(habitacionDto);

            if (habitacionDto.Foto != null)
            {
                habitacion.Foto = await _fileStorageService.GuardarArchivo(habitacionDto.Foto, "ImagesGlobal");
            }
            foreach (var servicioId in habitacionDto.HabitacionServicioOfrecido)
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
        public async Task Update(HabitacionModificacionDTO entidad)
        {
            
        }
    }


}
