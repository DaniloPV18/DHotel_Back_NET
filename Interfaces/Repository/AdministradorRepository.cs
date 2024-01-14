using DHotel_Back.DBContext;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;

namespace DHotel_Back.Interfaces.Repository
{
    public class AdministradorRepository : GenericRepository<Administrador>, IAdministradorRepository
    {
        private readonly ApplicationDbContext _context;

        public AdministradorRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
