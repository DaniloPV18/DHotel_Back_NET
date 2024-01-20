using DHotel_Back.DBContext;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace DHotel_Back.Interfaces.Repository
{
    public class PagoRepository : GenericRepository<Pago>, IPagoRepository
    {
        private readonly ApplicationDbContext _context;
        public PagoRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public new async Task<IEnumerable<Pago>> GetAllAsync()
        {
            return await _context.Pagos
                                 .Include(a => a.Administrador)
                                 .Include(h => h.Huesped)
                                 .Include(h => h.Habitacion)
                                    .ThenInclude(s => s.HabitacionServicioOfrecido)
                                    .ThenInclude(hso => hso.ServicioOfrecido)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<Pago>> GetAvailableAsync(Pago entidad)
        {

            return await _context.Pagos
                                .Where(p => (
                                p.FechaInicio <= entidad.FechaFin && p.FechaFin >= entidad.FechaInicio)
                                && p.EstadoId == 1
                                && p.HabitacionId == entidad.HabitacionId )
                                .ToListAsync();

        }
    }
}
