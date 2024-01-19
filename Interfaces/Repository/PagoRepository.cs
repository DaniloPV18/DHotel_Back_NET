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
                                 .Include(h => h.Habitacion)
                                 .ToListAsync();
        }
    }
}
