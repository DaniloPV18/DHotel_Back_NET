using DHotel_Back.DBContext;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace DHotel_Back.Interfaces.Repository
{
    public class HabitacionServicioOfrecidoRepository : GenericRepository<HabitacionServicioOfrecido>, IHabitacionServicioOfrecidoRepository
    {
        private readonly ApplicationDbContext _context;
        public HabitacionServicioOfrecidoRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> EliminarRegistrosHabitacion(int id)
        {
            var registrosAEliminar = _context.HabitacionServicioOfrecido
                                        .Where(x => x.HabitacionId == id);
            if (!registrosAEliminar.Any())
            {
                return false;
            }
            _context.HabitacionServicioOfrecido.RemoveRange(registrosAEliminar);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
