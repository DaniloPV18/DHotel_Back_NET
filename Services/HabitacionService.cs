using AutoMapper;
using DHotel_Back.DBContext;
using DHotel_Back.DTOs;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Interfaces.IServices;
using DHotel_Back.Models;

namespace DHotel_Back.Services
{
    public class HabitacionService
    {
        private readonly IGenericRepository<Habitacion> _repository;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _fileStorageService;
        private readonly ApplicationDbContext _context;  // Usado para operaciones adicionales

        public HabitacionService(IGenericRepository<Habitacion> repository, IMapper mapper, IFileStorageService fileStorageService, ApplicationDbContext context)
        {
            _repository = repository;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
            _context = context;
        }

        public async Task CrearHabitacionAsync(HabitacionCreacionDTO habitacionDto)
        {
            var habitacion = _mapper.Map<Habitacion>(habitacionDto);

            if (habitacionDto.Foto != null)
            {
                habitacion.Foto = await _fileStorageService.GuardarArchivo(habitacionDto.Foto, "ImagesGlobal");
            }

            foreach (var servicioId in habitacionDto.HabitacionServicioOfrecido)
            {
                var servicioExistente = await _context.ServiciosOfrecidos.FindAsync(servicioId);
                if (servicioExistente != null)
                {
                    habitacion.HabitacionServicioOfrecido.Add(new HabitacionServicioOfrecido
                    {
                        ServicioOfrecido = servicioExistente,
                        FechaRegistro = DateTime.Now
                    });
                }
            }

            await _repository.AddAsync(habitacion);
        }
    }


}
