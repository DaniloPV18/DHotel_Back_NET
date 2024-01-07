using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DHotel_Back.Utilidades
{
    public class Images
    {
        public static async Task<string> GuardarArchivo(IFormFile archivo)
        {
            // Asegúrate de que la carpeta para almacenar las imágenes exista
            var carpetaImagenes = Path.Combine(Directory.GetCurrentDirectory(), "ImagesGlobal");
            Directory.CreateDirectory(carpetaImagenes);
            // Genera un nombre único para el archivo
            var nombreArchivo = GenerarNombreUnico(archivo.FileName);
            var rutaCompleta = Path.Combine(carpetaImagenes, nombreArchivo);
            // Guarda el archivo
            using (var fileStream = new FileStream(rutaCompleta, FileMode.Create))
            {
                await archivo.CopyToAsync(fileStream);
            }
            // Retorna la ruta relativa o cualquier identificador que prefieras
            return nombreArchivo;
        }

        private static string GenerarNombreUnico(string nombreOriginal)
        {
            // Genera un nombre de archivo único usando un GUID
            var extension = Path.GetExtension(nombreOriginal);
            return $"{Guid.NewGuid()}{extension}";
        }
    }
}
