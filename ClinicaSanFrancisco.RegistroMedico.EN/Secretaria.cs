using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSanFrancisco.RegistroMedico.EN
{
    public class Secretaria
    {
        public Int64 ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DUI { get; set; }
        public Int32 NumeroTelefono { get; set; }
        public string Direccion { get; set; }

        //Constructor vacio
        public Secretaria() { }
        //ConstructorLleno
        public Secretaria(Int64 pID, string pNombre, string pApellido, string pDUI,
        Int32 pNumeroTelefono, string pDireccion)
        {
            ID = pID;
            Nombre = pNombre;
            Apellido = pApellido;
            DUI = pDUI;
            NumeroTelefono = pNumeroTelefono;
            Direccion = pDireccion;

        }
    }
}