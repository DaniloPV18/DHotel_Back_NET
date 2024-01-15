using DHotel_Back.DBContext;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;

namespace DHotel_Back.Interfaces.Repository
{
    public class HabitacionRepository : GenericRepository<Habitacion>, IHabitacionRepository
    {
        private readonly ApplicationDbContext _context;
        public HabitacionRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
