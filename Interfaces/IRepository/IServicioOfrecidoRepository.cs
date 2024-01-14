using DHotel_Back.Models;

namespace DHotel_Back.Interfaces.IRepository
{
    public interface IServicioOfrecidoRepository : IGenericRepository<ServicioOfrecido>
    {
        Task<IEnumerable<ServicioOfrecido>> BuscarServiciosActivos();
    }
}
