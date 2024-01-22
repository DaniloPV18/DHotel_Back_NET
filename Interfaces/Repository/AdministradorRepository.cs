using DHotel_Back.DBContext;
using DHotel_Back.Interfaces.IRepository;
using DHotel_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace DHotel_Back.Interfaces.Repository
{
    public class AdministradorRepository : GenericRepository<Administrador>, IAdministradorRepository
    {
        private readonly ApplicationDbContext _context;

        public AdministradorRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Administrador> GetAdministradorByCedula(string cedula)
        {
            return await _context.Administradores
                                    .FirstOrDefaultAsync(u => u.Cedula == cedula);

        }
    }
}
