using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class Usuarios
    {
        public Int64 ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public  string DUI { get; set; }
        public  Int32 NumeroTelefono { get; set; }
        public string Direccion { get; set; }
        public Int64 IDCargo { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public String Contrasena { get; set; }
        public DateTime UltimoCambioContrasena { get; set; }

        public Usuarios() { }

        public Usuarios(Int64 pID, string pNombres, string pApellidos, Int64 pIDCargo, string pEmail, string pNombreUuario, String pContrasena, DateTime pUltimoCambioContrasena) 
        {
            ID = pID;
            Nombres = pNombres;
            Apellidos = pApellidos;
            IDCargo = pIDCargo;
            Email = pEmail;
            NombreUsuario = pNombreUuario;
            Contrasena = pContrasena;
            UltimoCambioContrasena = pUltimoCambioContrasena;

        }
    }
}
