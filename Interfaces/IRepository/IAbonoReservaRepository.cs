using DHotel_Back.Models;

namespace DHotel_Back.Interfaces.IRepository
{
    public interface IAbonoReservaRepository : IGenericRepository<AbonoReserva>
    {
        Task<IEnumerable<AbonoReserva>> GetAllAsyncByPagoId(int idPago);
        Task<decimal> GetSumReserva(int idPago);
        Task<bool> VerificarSiTodasEstanAnuladas(int idPago);
    }
}
