namespace DHotel_Back.Interfaces.IServices
{
    public interface IFileStorageService
    {
        Task<string> GuardarArchivo(IFormFile archivo, string contenedor);
        Task<string> BuscarArchivo(string nombreArchivo, string contenedor);
        Task<bool> EliminarArchivo(string nombreArchivo, string contenedor);
    }
}
