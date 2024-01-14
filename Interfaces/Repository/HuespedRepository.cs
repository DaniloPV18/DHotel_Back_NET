using DHotel_Back.DBContext;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace DHotel_Back.Interfaces.Repository
{
    public class HuespedRepository : GenericRepository<Huesped>, IHuespedRepository
    {
        private readonly ApplicationDbContext _context;

        public HuespedRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Huesped>> BuscarHuespedesPorNombre(string nombre)
        {
            return await _context.Huespedes
                                 .Where(h => h.Nombres.Contains(nombre))
                                 .ToListAsync();
        }
        public async Task<IEnumerable<Huesped>> BuscarHuespedesPorNombreApellidos(string palabra)
        {
            return await _context.Huespedes
                .Where(h => h.Nombres.Contains(palabra) || h.Apellidos.Contains(palabra))
                .ToArrayAsync();
        }
    }
}
