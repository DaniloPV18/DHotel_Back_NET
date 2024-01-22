using DHotel_Back.Models;

namespace DHotel_Back.Interfaces.IRepository
{
    public interface IAdministradorRepository : IGenericRepository<Administrador>
    {
        Task<Administrador> GetAdministradorByCedula(string cedula);
    }
}
