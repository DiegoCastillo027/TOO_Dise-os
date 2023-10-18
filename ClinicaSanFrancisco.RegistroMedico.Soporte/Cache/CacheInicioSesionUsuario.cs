using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.Soporte.Cache
{
    public static class CacheInicioSesionUsuario
    {
        public static Int64 ID{ get; set; }
        public static string Nombres { get; set; }
        public static string Apellidos { get; set; }
        public static string DUI { get; set; }
        public static Int32 NumeroTelefono { get; set; }
        public static string Direccion { get; set; }
        public static string Nombre { get; set; }
        public static string Email { get; set; }
        public static string NombreUsuario { get; set; }
        public static String Contrasena { get; set; }
        public static DateTime UltimoCambioContrasena { get; set; }
    }
}
