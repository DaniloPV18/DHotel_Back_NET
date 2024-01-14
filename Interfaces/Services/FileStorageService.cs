using DHotel_Back.Interfaces.IServices;

namespace DHotel_Back.Interfaces.Services
{
    public class FileStorageService : IFileStorageService
    {
        public async Task<string> GuardarArchivo(IFormFile archivo, string contenedor)
        {
            var carpetaImagenes = Path.Combine(Directory.GetCurrentDirectory(), contenedor);
            Directory.CreateDirectory(carpetaImagenes);

            var nombreArchivo = GenerarNombreUnico(archivo.FileName);
            var rutaCompleta = Path.Combine(carpetaImagenes, nombreArchivo);

            using (var fileStream = new FileStream(rutaCompleta, FileMode.Create))
            {
                await archivo.CopyToAsync(fileStream);
            }

            return nombreArchivo;
        }

        private string GenerarNombreUnico(string nombreOriginal)
        {
            var extension = Path.GetExtension(nombreOriginal);
            return $"{Guid.NewGuid()}{extension}";
        }
    }
}
