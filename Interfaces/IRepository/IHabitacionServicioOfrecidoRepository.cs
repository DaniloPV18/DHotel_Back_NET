using DHotel_Back.Models;

namespace DHotel_Back.Interfaces.IRepository
{
    public interface IHabitacionServicioOfrecidoRepository : IGenericRepository<HabitacionServicioOfrecido>
    {
        Task<bool> EliminarRegistrosHabitacion(int id);
    }
}
