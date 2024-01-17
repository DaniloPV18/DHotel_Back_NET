using DHotel_Back.DBContext;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace DHotel_Back.Interfaces.Repository
{
    public class HabitacionRepository : GenericRepository<Habitacion>, IHabitacionRepository
    {
        private readonly ApplicationDbContext _context;
        public HabitacionRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Habitacion>> ConsultarRelaciones()
        {
            return await _context.Habitaciones
                            .Include(h => h.Administrador)
                            .Include(h => h.HabitacionServicioOfrecido)
                                .ThenInclude(hso => hso.ServicioOfrecido)
                            .ToListAsync();
        }
    }
}
