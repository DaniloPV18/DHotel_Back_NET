namespace DHotel_Back.Interfaces.IServices
{
    public interface IFileStorageService
    {
        Task<string> GuardarArchivo(IFormFile archivo, string contenedor);
    }
}
