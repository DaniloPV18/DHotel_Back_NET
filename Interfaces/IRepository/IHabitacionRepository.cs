using DHotel_Back.Models;

namespace DHotel_Back.Interfaces.IRepository
{
    public interface IHabitacionRepository : IGenericRepository<Habitacion>
    {
        Task<IEnumerable<Habitacion>> ConsultarRelaciones();
    }
}
