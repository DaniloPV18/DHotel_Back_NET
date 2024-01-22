using DHotel_Back.DBContext;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DHotel_Back.Interfaces.Repository
{
    public class AbonoReservaRepository : GenericRepository<AbonoReserva>, IAbonoReservaRepository
    {
        private readonly ApplicationDbContext _context;

        public AbonoReservaRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AbonoReserva>> GetAllAsyncByPagoId(int idPago)
        {
            return await _context.AbonosReservas
                                    .Where(ar => ar.PagoId == idPago)
                                    .Include(ar => ar.Administrador)
                                    .ToListAsync();
        }

        public async Task<decimal> GetSumReserva(int idPago)
        {
            return await _context.AbonosReservas
                                    .Where(ar => ar.PagoId == idPago && ar.EstadoId == 1)
                                    .SumAsync(p => p.ValorPagado ?? 0);
        }

        public async Task<bool> VerificarSiTodasEstanAnuladas(int idPago)
        {
            var cantidadHabilitadas = await _context.AbonosReservas
                                            .Where(ar => ar.EstadoId == 3 && ar.PagoId == idPago)
                                            .CountAsync();
            var cantidadTotal = await _context.AbonosReservas
                                            .Where(ar => ar.PagoId == idPago)
                                            .CountAsync();
            if (cantidadHabilitadas == cantidadTotal)
            {
                return true;
            }
            return false;
        }
    }
}
