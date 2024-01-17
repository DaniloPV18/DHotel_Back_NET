using DHotel_Back.Models;

namespace DHotel_Back.Interfaces.IRepository
{
    public interface IHabitacionRepository : IGenericRepository<Habitacion>
    {
        new Task<Habitacion> GetByIdAsync(int id);
        new Task<IEnumerable<Habitacion>> GetAllAsync();
    }
}
