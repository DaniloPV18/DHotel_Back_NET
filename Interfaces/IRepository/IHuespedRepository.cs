using DHotel_Back.Models;

namespace DHotel_Back.Interfaces.IRepository
{
    public interface IHuespedRepository : IGenericRepository<Huesped>
    {
        Task<IEnumerable<Huesped>> BuscarHuespedesPorNombre(string nombre);
        Task<IEnumerable<Huesped>> BuscarHuespedesPorNombreApellidos(string palabra);
    }
}
