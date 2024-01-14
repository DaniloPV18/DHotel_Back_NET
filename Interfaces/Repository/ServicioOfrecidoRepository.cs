using DHotel_Back.DBContext;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace DHotel_Back.Interfaces.Repository
{
    public class ServicioOfrecidoRepository : GenericRepository<ServicioOfrecido>, IServicioOfrecidoRepository
    {
        private readonly ApplicationDbContext _context;
        public ServicioOfrecidoRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ServicioOfrecido>> BuscarServiciosActivos()
        {
            return await _context.ServiciosOfrecidos
                .Where(so => so.EstadoId == 1).ToListAsync();
        }
    }
}
