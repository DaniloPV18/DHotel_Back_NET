using DHotel_Back.Models;

namespace DHotel_Back.Interfaces.IRepository
{
    public interface IPagoRepository : IGenericRepository<Pago>
    {
        new Task<IEnumerable<Pago>> GetAllAsync();
        Task<IEnumerable<Pago>> GetAvailableAsync(Pago entidad);
    }
}
